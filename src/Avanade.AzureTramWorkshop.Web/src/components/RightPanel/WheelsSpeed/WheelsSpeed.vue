<script setup lang="ts">
import store from "@/store";
import DiodeOff from "../../shared/Icons/DiodeOff.vue";
import DiodeOn from "../../shared/Icons/DiodeOn.vue";
import WheelsSpeedMask from "./Icons/WheelsSpeedMask.vue";
import WheelsSpeedArrow from "./Icons/WheelsSpeedArrow.vue";
</script>

<template>
    <div class="wheels-speed-content">
        <div class="mask">
            <WheelsSpeedMask></WheelsSpeedMask>
        </div>
        <div class="arrow-content">
            <div class="arrow" :style="{rotate: store.getters['speed/wheelSpeedArrow']}">
                <WheelsSpeedArrow></WheelsSpeedArrow>
            </div>
        </div>
        <div class="wheels-speed-value">
            <span class="background">000</span>
            <span class="value">{{ store.getters['speed/wheelSpeed'] }}</span>
        </div>
        <div class="wheels-slip">
            <DiodeOn v-if="store.getters['speed/isSlip']" ></DiodeOn>
            <DiodeOff v-else ></DiodeOff>
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
    z-index: 2;
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

.wheels-slip {
    position: absolute;
    width: 21px;
    height: 21px;
    bottom: 12px;
    right: 12px;
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

.arrow-content {
    display: flex;
    justify-content: center;
    width: 359px;
    height: 32px;
    position: absolute;
    top: 121px;
    z-index: 1;
}

.arrow-content .arrow {
    width: 190px;
}
</style>