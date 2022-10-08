<script setup lang="ts">
import store from "@/store";
import DiodeOff from "../../shared/Icons/DiodeOff.vue";
import DiodeOn from "../../shared/Icons/DiodeOn.vue";
</script>

<template>
    <div class="temperatures-content">
        <div class="engine-temperature">
            <div class="temperature-gradient" :style="{ 'width': store.getters['temperature/engineGradientWidth'] + 'px' }"></div>
            <div class="temperature-value">
                <span class="background">000</span>
                <span class="value">{{ store.getters['temperature/engine'] }}</span>
            </div>
        </div>
        <div class="inverter-temperature">
            <div class="temperature-gradient" :style="{ 'width': store.getters['temperature/inverterGradientWidth'] + 'px' }"></div>
            <div class="temperature-value">
                <span class="background">000</span>
                <span class="value">{{ store.getters['temperature/inverter'] }}</span>
            </div>
        </div>
        <div class="air-temperature">
            <div class="temperature-gradient" :style="{ 'width': store.getters['temperature/airGradientWidth'] + 'px' }"></div>
            <div class="temperature-value">
                <span class="background">000</span>
                <span class="value">{{ store.getters['temperature/air'] }}</span>
            </div>
        </div>
        <div class="heating-cooling-diode">
            <div class="heating">
                <DiodeOn></DiodeOn>
            </div>
            <div class="cooling">
                <DiodeOff></DiodeOff>
            </div>
        </div>
    </div>
</template>

<style scoped>
.temperatures-content {
    background-image: url('@/assets/img/TEMPERATURA.png');
    width: 359px;
    height: 273px;
    margin-top: 4px;
}

.engine-temperature,
.inverter-temperature,
.air-temperature {
    width: 350px;
    height: 60px;
    margin: 5px auto 0;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: flex-end;
}

.heating-cooling-diode {
    float: right;
    width: 30px;
    height: 60px;
    padding: 5px 0;
    margin-right: 5px;
}

.heating,
.cooling {
    width: 21px;
    height: 21px;
    margin: 6px;
}

.temperature-gradient {
    box-sizing: border-box;
    border: solid 4px;
    border-radius: 4px;
    width: 232px;
    height: 26px;
    margin: 5px;
}

.air-temperature .temperature-gradient {
    background-image: url('@/assets/img/air-temperature-gradient.svg');
}

.engine-temperature .temperature-gradient {
    background-image: url('@/assets/img/engine-temperature-gradient.svg');
}

.inverter-temperature .temperature-gradient {
    background-image: url('@/assets/img/inverter-temperature-gradient.svg');
}

.temperature-value {
    width: 100px;
    height: 60px;
    position: relative;
}

.temperature-value .background,
.temperature-value .value {
    width: 100px;
    height: 60px;
    position: absolute;
    line-height: 60px;
    font-size: 70px;
    font-family: 'Digital 7 Mono';
    letter-spacing: 2px;
}

.temperature-value .background {
    color: #171B23;
}

.temperature-value .value {
    color: white;
    text-align: end;
}
</style>