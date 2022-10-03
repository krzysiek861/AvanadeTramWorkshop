<script setup lang="ts">
import PantographRed from "./Icons/PantographRed.vue";
import TramRed from "./Icons/TramRed.vue";
import Lightning from "./Icons/Lightning.vue";
import TramGreen from "./Icons/TramGreen.vue";
import PantographGreen from "./Icons/PantographGreen.vue";

</script>

<template>
    <div class="tram-content">
        <PantographGreen></PantographGreen>
        <TramGreen></TramGreen>
        <div class="lightning">
            <Lightning></Lightning>
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