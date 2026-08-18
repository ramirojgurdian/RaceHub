<script setup lang="ts">
import { onMounted, ref } from 'vue'
import { fetchRaceEvents, type RaceEvent } from '@/services/racehubapi'
import counter from '@/components/CounterComponent.vue'
import cards from '@/components/RaceCards.vue'

const raceEvents = ref<RaceEvent[]>([])
const nextRace = ref<RaceEvent | null>(null)

onMounted(async () => {
  raceEvents.value = await fetchRaceEvents("Formula 1")
  nextRace.value = getNextRace()
})

function getNextRace(): RaceEvent | null {
  const events = raceEvents.value
  if (!events.length) return null

  const upcoming = events
    .filter((e) => new Date(e.StartTime).valueOf() > Date.now())
    .sort((a, b) => new Date(a.StartTime).valueOf() - new Date(b.StartTime).valueOf())

  return upcoming[0] ?? null
}

</script>

<template>
  <counter :race-event="nextRace"></counter>
  <v-spacer></v-spacer>
  <cards :race-events="raceEvents"></cards>
</template>

<style>

</style>
