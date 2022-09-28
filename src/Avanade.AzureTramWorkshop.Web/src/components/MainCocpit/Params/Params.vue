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
    </div>
</template>

<style scoped>
.params-content {
    display: flex;
    flex-direction: column;
}

.params-row {
    display: flex;
    flex-direction: row;
    width: 783px;
    justify-content: space-between;
}
</style>