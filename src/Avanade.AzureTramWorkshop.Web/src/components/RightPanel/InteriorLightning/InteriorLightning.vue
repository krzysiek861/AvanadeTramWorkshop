<script setup lang="ts">
import store from "@/store";
import DiodeOff from "../../shared/Icons/DiodeOff.vue";
import DiodeOn from "../../shared/Icons/DiodeOn.vue";
</script>

<template>
    <div class="interior-lightning-content">
        <div class="lightning-diode">
            <DiodeOn v-if="store.getters['other/light']" ></DiodeOn>
            <DiodeOff v-else ></DiodeOff>
        </div>
    </div>
</template>

<style scoped>
.interior-lightning-content {
    background-image: url('@/assets/img/oswietlenie_wewnatrz.png');
    width: 348px;
    height: 36px;
    margin-top: 8px;
    position: relative;
}

.lightning-diode {
    width: 21px;
    height: 21px;
    position: absolute;
    right: 7px;
    top: 7px
}
</style>