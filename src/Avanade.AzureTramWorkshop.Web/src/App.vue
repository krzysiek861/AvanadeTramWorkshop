<script setup lang="ts">
import store from './store';
import { HubConnectionBuilder, LogLevel } from '@aspnet/signalr'
import MainCocpit from "./components/MainCocpit/MainCocpit.vue";
import MemeGenerator from "./components/MemeGenerator/MemeGenerator.vue";
import RightPanel from "./components/RightPanel/RightPanel.vue";

const connection = new HubConnectionBuilder()
    .withUrl('')
    .configureLogging(LogLevel.Information)
    .build();
connection.start();
connection.on('newMessage', (message) => {
    if (message.sensor_name === 'Weight') {
        store.dispatch('weight/updateWeight', message.sensor_value);
    } else if (message.sensor_name === 'Speed') {
        store.dispatch('speed/updateTramSpeed',message.sensor_value)
    } else if (message.sensor_name === 'Temperature') {
        store.dispatch('temperature/updateEngineTemperature',message.sensor_value)
    }
});

</script>

<template>
    <div class="main">
        <div class="first-column">
            <div class="main-cocpit">
                <MainCocpit></MainCocpit>
            </div>
            <div class="meme-generator">
                <MemeGenerator></MemeGenerator>
            </div>
        </div>
        <div class="second-column">
            <RightPanel></RightPanel>
        </div>
    </div>
</template>

<style scoped>
@font-face {
    font-family: 'Digital 7 Mono';
    src: url('@/assets/font/digital-7-mono.ttf');
}

.main {
    display: flex;
    flex-direction: row;
    width: fit-content;
}

.first-column {
    display: flex;
    flex-direction: column;
}

.main-cocpit {
    height: 876px;
    width: 1537px;
    background-image: url('./assets/img/SCREEN_BG.png');
    position: relative;
}

.meme-generator {
    height: 204px;
    width: 1537px;
    background-image: url('./assets/img/MEME_GENERATOR_BG.png');
    display: flex;
    justify-content: center;
}

.second-column {
    width: 383px;
    height: 1080px;
    background-image: url('./assets/img/RIGHT_PANEL_BG.png');
}
</style>
