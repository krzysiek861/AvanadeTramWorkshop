<script setup lang="ts">
import Amperage from './Amperage/Amperage.vue';
import ParamsList from './ParamsList/ParamsList.vue';
import Batteries from './Batteries/Batteries.vue';
</script>

<template>
    <div class="params-content">
        <Amperage></Amperage>
        <div class="params-row">
            <Batteries></Batteries>
            <ParamsList></ParamsList>
        </div>
        <div class="params-lines"></div>
    </div>
</template>

<style scoped>
.params-content {
    display: flex;
    flex-direction: column;
    position: relative;
}

.params-lines {
    position: absolute;
    background-image: url('@/assets/img/lines.png');
    width: 451px;
    height: 430px;
    top: 85px;
    left: -280px;
}

.params-row {
    display: flex;
    flex-direction: row;
    width: 783px;
    justify-content: space-between;
}
</style>