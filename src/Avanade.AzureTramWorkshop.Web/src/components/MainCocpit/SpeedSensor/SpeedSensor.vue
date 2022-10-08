<script setup lang="ts">
import store from "@/store";
import SpeedArrow from "./Icons/SpeedArrow.vue";
</script>

<template>
    <div class="speed-sensor-content">
        <img src="@/assets/img/PREDKOSC.png">
        <div class="speed-value">{{ store.getters['speed/tramSpeed'] }}</div>
        <div class="speed-arrow" :style="{rotate: store.getters['speed/tramSpeedArrow']}">
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