<script setup lang="ts">
import WheelsSpeed from "./WheelsSpeed/WheelsSpeed.vue";
import Temperatures from "./Temperatures/Temperatures.vue";
import SmokeSensor from "./SmokeSensor/SmokeSensor.vue";
import InteriorLightning from "./InteriorLightning/InteriorLightning.vue";
import Logo from "./Logo/Logo.vue";
import SpeedLever from "./SpeedLever/SpeedLever.vue";</script>

<template>
    <div class="right-panel-content">
        <WheelsSpeed></WheelsSpeed>
        <Temperatures></Temperatures>
        <SmokeSensor></SmokeSensor>
        <InteriorLightning></InteriorLightning>
        <SpeedLever></SpeedLever>
        <Logo></Logo>
    </div>
</template>

<style scoped>
.right-panel-content {
    display: flex;
    flex-direction: column;
    align-items: center;
}
</style>