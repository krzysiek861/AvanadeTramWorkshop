<script setup lang="ts">
import AmperageDark from './Icons/AmperageDark.vue';
</script>

<template>
    <div class="amperage-content">
        <div class="amperage-icons">
            <div v-for="n in 36" class="amperage-icon">
                <AmperageDark></AmperageDark>
            </div>
        </div>
        <div class="amperage-scale"></div>
    </div>
</template>

<style scoped>
.amperage-content {
    display: flex;
    flex-direction: column;
    align-items: center;
    margin-bottom: 20px;
}

.amperage-icons {
    width: 743px;
    height: 34px;
    display: flex;
    margin: 12px 0;
    overflow: hidden;
}

.amperage-icon {
    flex-grow: 1;
    margin-left: -10px;
}

.amperage-scale {
    width: 743px;
    height: 34px;
    background-image: url('@/assets/img/amperage_scale.png');
}
</style>