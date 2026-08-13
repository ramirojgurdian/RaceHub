<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import { ref } from 'vue'

const drawer = ref(false)
</script>

<template>
  <v-app>
    <v-app-bar extended>
      <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
      <v-app-bar-title>RaceHub</v-app-bar-title>
      <v-btn icon="mdi-dots-vertical"></v-btn>
    </v-app-bar>
    <v-navigation-drawer v-model="drawer">
      <RouterLink to="/">Home</RouterLink>
      <v-spacer></v-spacer>
      <RouterLink to="/about">About</RouterLink>
    </v-navigation-drawer>
    <v-main>
      <RouterView />
    </v-main>
  </v-app>
</template>

<style></style>

<!-- <div>
    <nav>
    </nav>
  </div> -->
