<script setup lang="ts">
import type { RaceEvent } from '@/services/racehubapi'
import { computed, onMounted, onUnmounted, ref } from 'vue'

interface Props {
  raceEvent: RaceEvent | null
}

let intervalId: ReturnType<typeof setInterval> | null = null

onMounted(async () => {
  intervalId = setInterval(() => {
    now.value = Date.now()
  }, 1000)
})
onUnmounted(async () => {
  if (intervalId) clearInterval(intervalId)
})

const props = defineProps<Props>()
const targetDate = computed<Date | null>(() => {
  return props.raceEvent ? new Date(props.raceEvent.StartTime) : new Date()
})

const nextRace = computed<RaceEvent | null>(() => {
  return props.raceEvent
})

const remainingMs = computed(() => {
  const date = targetDate.value
  return Math.max(date ? date.valueOf() - now.value : 0, 0)
})

const now = ref(Date.now())
const days = computed(() => Math.floor(remainingMs.value / 86_400_000))
const hours = computed(() => Math.floor((remainingMs.value % 86_400_000) / 3_600_000))
const minutes = computed(() => Math.floor((remainingMs.value % 3_600_000) / 60_000))
const seconds = computed(() => Math.floor((remainingMs.value % 60_000) / 1000))
</script>

<template>
  <div>
    <div class="countdown">
      <span class="racename">{{ nextRace?.EventName }}</span>
    </div>
    <div class="countdown">
      <div class="countdown-item">
        <span class="countdown-number">{{ days }}</span>
        <span class="countdown-label">DAYS</span>
      </div>
      <div class="countdown-item">
        <span class="countdown-number">{{ hours }}</span>
        <span class="countdown-label">HOURS</span>
      </div>
      <div class="countdown-item">
        <span class="countdown-number">{{ minutes }}</span>
        <span class="countdown-label">MIN</span>
      </div>
      <div class="countdown-item">
        <span class="countdown-number">{{ seconds }}</span>
        <span class="countdown-label">SEC</span>
      </div>
    </div>
  </div>
</template>

<style>
.countdown {
  display: flex;
  justify-content: center;
  gap: 1.5rem;
  margin-top: 2rem;
}

.countdown-item {
  text-align: center;
}

.countdown-number {
  font-size: 4rem;
  font-weight: 800;
  letter-spacing: -0.08em;
}

.countdown-label {
  display: block;
  margin-top: 0.5rem;
  font-size: 0.75rem;
  letter-spacing: 0.2em;
  text-transform: uppercase;
  color: rgba(255, 255, 255, 0.7);
}
</style>
