<script setup lang="ts">
import { onMounted, ref } from 'vue'
import { fetchRaceEvents, type RaceEvent } from '@/services/racehubapi'
import counter from '@/components/CounterComponent.vue'

const raceEvents = ref<RaceEvent[]>([])
const nextRace = ref<RaceEvent | null>(null)

onMounted(async () => {
  raceEvents.value = await fetchRaceEvents()
  nextRace.value = getNextRace()
})

function getNextRace(): RaceEvent | null {
  const events = raceEvents.value
  if (!events.length) return null

  // const upcoming = events
  //   .map((item) => new Date(item.StartTime))
  //   .filter((date) => date.valueOf() > Date.now())
  //   .sort((a, b) => a.valueOf() - b.valueOf())

  // const firstEvent = events[0]!
  const upcoming = events
    .filter((e) => new Date(e.StartTime).valueOf() > Date.now())
    .sort((a, b) => new Date(a.StartTime).valueOf() - new Date(b.StartTime).valueOf())

  return upcoming[0] as RaceEvent
}

function formatRaceDate(isoString: string) {
  return new Intl.DateTimeFormat('en-US', {
    month: 'short',
    day: 'numeric',
    year: 'numeric',
    hour: '2-digit',
    minute: '2-digit',
    hour12: false,
    timeZone: 'UTC',
  }).format(new Date(isoString))
}
</script>

<template>
  <counter :race-event="nextRace"></counter>
  <v-spacer></v-spacer>
  <v-container>
    <v-row>
      <v-col v-for="raceEvent in raceEvents" :key="raceEvent.StartTime" cols="4">
        <v-card height="200" class="race-event-card">
          <v-card-title>{{ raceEvent.EventName }}</v-card-title>
          <v-card-subtitle
            >{{ raceEvent.Track.Name }}, {{ raceEvent.Track.Country }}</v-card-subtitle
          >
          <v-card-text>
            <div>Series: {{ raceEvent.Series }}</div>
            <div>{{ formatRaceDate(raceEvent.StartTime) }} UTC</div>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<style>
.racename {
  text-align: center;
  font-size: 4rem;
}
</style>
