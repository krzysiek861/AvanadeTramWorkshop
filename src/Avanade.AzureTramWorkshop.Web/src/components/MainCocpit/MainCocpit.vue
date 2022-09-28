<script setup lang="ts">
import SpeedSensor from './SpeedSensor/SpeedSensor.vue';
import Params from './Params/Params.vue';
</script>

<template>
    <div class="main-cocpit-content">
        <div class="main-cocpit-layout">
            <div class="main-cocpit-row">
                <div class="speed">
                    <SpeedSensor></SpeedSensor>
                </div>
                <div class="params">
                    <Params></Params>
                </div>
            </div>
            <div class="tram"></div>
        </div>
    </div>
</template>

<style scoped>
.main-cocpit-content {
    width: 1263px;
    height: 692px;
    background-image: url('@/assets/img/RAMKI_na_screenie.png');
    position: absolute;
    top: 93px;
    left: 133px;
}

.main-cocpit-layout {
    display: flex;
    flex-direction: column;
}

.main-cocpit-row {
    display: flex;
    flex-direction: row;
}

.speed {
    height: 405px;
    width: 480px;
    display: flex;
    justify-content: center;
    align-items: center;
}

.params {
    height: 405px;
    flex-grow: 1;
}
</style>