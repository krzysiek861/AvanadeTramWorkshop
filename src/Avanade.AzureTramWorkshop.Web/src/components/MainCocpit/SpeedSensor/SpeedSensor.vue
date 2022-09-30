<script setup lang="ts">
import { computed } from "@vue/reactivity";
import { ref } from "vue";
import SpeedArrow from "./Icons/SpeedArrow.vue";

const speedToDegreesBy5 = [-20, -5, 10, 23, 35.5, 50, 62, 77, 90.5, 105, 119];

const speed = ref(32);
const arrowRotation = computed(() => {
    const index = Math.floor(speed.value / 5);
    const remainder = speed.value % 5;
    const speedChangeFactor = remainder / 5;
    return remainder > 0
        ? `${speedToDegreesBy5[index] + ((speedToDegreesBy5[index + 1] - speedToDegreesBy5[index]) * speedChangeFactor)}deg`
        : `${speedToDegreesBy5[index]}deg`
})

</script>

<template>
    <div class="speed-sensor-content">
        <img src="@/assets/img/PREDKOSC.png">
        <div class="speed-value">{{ speed }}</div>
        <div class="speed-arrow" :style="{rotate: arrowRotation}">
            <div class="arrow">
                <SpeedArrow></SpeedArrow>
            </div>
        </div>
    </div>
</template>

<style scoped>
.speed-sensor-content {
    width: 373px;
    height: 296px;
    display: flex;
    justify-content: center;
    align-items: center;
    position: relative;
    z-index: 2;
}

.speed-value {
    position: absolute;
    width: 80px;
    height: 170px;
    color: white;
    line-height: 230px;
    text-align: center;
    font-size: 70px;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    font-weight: 700;
}

.speed-arrow {
    position: absolute;
    width: 370px;
    height: 34px;
    top: 173px;
    left: 0;
    rotate: -20deg;
    z-index: 1;
}

.speed-arrow .arrow {
    height: 34px;
    width: 68px;
    overflow: hidden;
}
</style>