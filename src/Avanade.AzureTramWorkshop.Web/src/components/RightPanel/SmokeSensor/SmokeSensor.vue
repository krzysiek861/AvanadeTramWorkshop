<script setup lang="ts">
import store from "@/store";
import DiodeOff from "../../shared/Icons/DiodeOff.vue";
import DiodeOn from "../../shared/Icons/DiodeOn.vue";
</script>

<template>
    <div class="smoke-sensor-content">
        <div class="smoke-diode">
            <DiodeOn v-if="store.getters['other/smoke']" ></DiodeOn>
            <DiodeOff v-else ></DiodeOff>
        </div>
    </div>
</template>

<style scope>
    .smoke-sensor-content {
        background-image: url('@/assets/img/czujnik_dymu.png');
        width: 348px;
        height: 36px;
        margin-top: 8px;
        position: relative;
    }

    .smoke-diode {
        width: 21px;
        height: 21px;
        position: absolute;
        right: 7px;
        top: 7px
    }
</style>