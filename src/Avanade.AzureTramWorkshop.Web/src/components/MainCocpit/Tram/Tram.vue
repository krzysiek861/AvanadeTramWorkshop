<script setup lang="ts">
import PantographRed from "./Icons/PantographRed.vue";
import TramRed from "./Icons/TramRed.vue";

</script>

<template>
    <div class="tram-content">
        <PantographRed></PantographRed>
        <TramRed></TramRed>
    </div>
</template>

<style scoped>
    .tram-content {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        height: 285px;
    }
</style>