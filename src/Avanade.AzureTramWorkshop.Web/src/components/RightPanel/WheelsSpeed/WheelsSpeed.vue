<script setup lang="ts">
import WheelsSpeedMask from "./Icons/WheelsSpeedMask.vue";

</script>

<template>
    <div class="wheels-speed-content">
        <div class="mask">
            <WheelsSpeedMask></WheelsSpeedMask>
        </div>
        <div class="wheels-speed-value">
            <span class="background">000</span>
            <span class="value">10</span>
        </div>
    </div>
</template>

<style scoped>
.wheels-speed-content {
    background-image: url('@/assets/img/PREDKOSC_KOL.png');
    width: 359px;
    height: 272px;
    position: relative;
}

.wheels-speed-content .mask {
    position: absolute;
    width: 359px;
    display: flex;
    justify-content: center;
    top: 109px;
}

.wheels-speed-value {
    position: absolute;
    width: 95px;
    height: 59px;
    bottom: 47px;
    right: 8px;
    font-family: 'Digital 7 Mono';
    font-weight: 400;
    line-height: 58px;
    font-size: 58px;
    letter-spacing: 7px;
}

.wheels-speed-value span {
    position: absolute;
    text-align: end;
}

.wheels-speed-value .background {
    color: #13393C;
}

.wheels-speed-value .value {
    color: white;
    right: -3px;
}

</style>