<script setup lang="ts">
import type {RaceEvent} from "@/services/racehubapi.ts";

interface Props {
  raceEvent: RaceEvent
}
const props = defineProps<Props>()

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
  <v-card height="200" class="race-event-card" >
    <v-card-title>{{ raceEvent.EventName }}</v-card-title>
    <v-card-subtitle
    >{{ raceEvent.Track.Name }}, {{ raceEvent.Track.Country }}</v-card-subtitle
    >
    <v-card-text>
      <div>Series: {{ raceEvent.Series }}</div>
      <div>{{ formatRaceDate(raceEvent.StartTime) }} UTC</div>
    </v-card-text>
  </v-card>
</template>

<style scoped>

</style>
