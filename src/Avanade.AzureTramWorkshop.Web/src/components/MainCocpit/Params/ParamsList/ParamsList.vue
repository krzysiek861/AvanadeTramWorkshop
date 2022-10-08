<script setup lang="ts">
import store from "@/store";
</script>
<template>
    <div class="params-list-content">
        <div class="param-value"><span class="background">000</span><span class="value">{{ store.getters['parameters/powerConsumption'] }}</span></div>
        <div class="param-value"><span class="background">000</span><span class="value">{{ store.getters['parameters/batteryVoltage'] }}</span></div>
        <div class="param-value"><span class="background">000</span><span class="value">{{ store.getters['parameters/tractionVoltage'] }}</span></div>
        <div class="param-value"><span class="background">000</span><span class="value">{{ store.getters['parameters/weightInTons'] }}</span></div>
    </div>
</template>

<style scoped>
.params-list-content {
    background-image: url('@/assets/img/LICZNIKI_SCREEN.png');
    width: 593px;
    height: 297px;
    margin-right: 8px;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    align-items: flex-end;
}

.param-value {
    width: 115px;
    height: 67.5px;
    position: relative;
    font-size: 65px;
    line-height: 65px;
    letter-spacing: 7px;
    font-family: 'Digital 7 Mono';
    font-weight: 400;
}

.param-value .background {
    left: 4px;
    color: #13393C;
}

.param-value .value {
    color: #30FF30;
}

.param-value span {
    position: absolute;
}

span.value {
    color: white;
    right: 0;
}
</style>