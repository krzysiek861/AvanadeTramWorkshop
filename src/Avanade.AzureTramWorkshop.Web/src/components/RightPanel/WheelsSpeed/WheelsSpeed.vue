<script setup lang="ts">
import WheelsSpeedMask from "./Icons/WheelsSpeedMask.vue";

</script>

<template>
    <div class="wheels-speed-content">
        <div class="mask">
            <WheelsSpeedMask></WheelsSpeedMask>
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
</style>