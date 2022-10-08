<script setup lang="ts">
import store from "@/store";
import PantographRed from "./Icons/PantographRed.vue";
import TramRed from "./Icons/TramRed.vue";
import Lightning from "./Icons/Lightning.vue";
import TramGreen from "./Icons/TramGreen.vue";
import PantographGreen from "./Icons/PantographGreen.vue";

</script>

<template>
    <div class="tram-content">
        <PantographGreen v-if="store.getters['parameters/tractionVoltage']"></PantographGreen>
        <PantographRed v-else ></PantographRed>
        <TramGreen v-if="store.getters['parameters/batteryVoltage']"></TramGreen>
        <TramRed v-else></TramRed>
        <div class="lightning">
            <Lightning v-if="store.getters['other/light']"></Lightning>
        </div>
    </div>
</template>

<style scoped>
.tram-content {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    height: 285px;
    position: relative;
}

.tram-content .lightning {
    position: absolute;
    width: 1097px;
    height: 57px;
    top: 130px;
    left: 80px;
    z-index: 1;
}

.tram-content>svg {
    z-index: 2;
}
</style>