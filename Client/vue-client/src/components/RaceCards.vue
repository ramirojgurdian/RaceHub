<script setup lang="ts">

import type {RaceEvent} from "@/services/racehubapi.ts";
import card from '@/components/RaceEventCard.vue'
import {computed} from "vue";
interface Props {
  raceEvents: RaceEvent[]
}
const props = defineProps<Props>()

const upcomingRaces = computed(() =>
  props.raceEvents.filter(r => Date.parse(r.StartTime) > Date.now())
)

const pastRaces = computed(() =>
  props.raceEvents.filter(r => Date.parse(r.StartTime) <= Date.now())
)


</script>

<template>
  <v-container>
    <v-container>
      <h2>Upcoming Races</h2>
      <v-row>
        <v-col v-for="raceEvent in upcomingRaces" :key="raceEvent.StartTime" cols="12" sm="6" md="4">
          <card :raceEvent="raceEvent"></card>
        </v-col>
      </v-row>

      <h2 style="margin-top: 40px">Past Races</h2>
      <v-row>
        <v-col v-for="raceEvent in pastRaces" :key="raceEvent.StartTime" cols="12" sm="6" md="4">
          <card :raceEvent="raceEvent"></card>
        </v-col>
      </v-row>
    </v-container>
    <v-row>

    </v-row>
  </v-container>
</template>

<style scoped>

</style>
