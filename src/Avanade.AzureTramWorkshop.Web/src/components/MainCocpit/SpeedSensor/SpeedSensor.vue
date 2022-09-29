<script setup lang="ts"></script>

<template>
    <div class="speed-sensor-content">
        <div class="speed-value">0</div>
    </div>
</template>

<style scoped>
.speed-sensor-content {
    background-image: url('@/assets/img/PREDKOSC.png');
    width: 373px;
    height: 296px;
    display: flex;
    justify-content: center;
    align-items: center;
    position: relative;
}

.speed-value {
    position: absolute;
    width: 80px;
    height: 170px;
    color: white;
    line-height: 230px;
    text-align: center;
    font-size: 70px;
}
</style>