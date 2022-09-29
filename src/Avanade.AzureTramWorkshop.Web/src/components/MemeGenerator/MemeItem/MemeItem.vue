<script setup lang="ts">
import DiodeOff from "../../shared/Icons/DiodeOff.vue";

</script>

<template>
    <div class="meme-content">
        <div class="label">Great job!</div>
        <div class="icon">
            <DiodeOff></DiodeOff>
        </div>
    </div>
</template>

<style scoped>
    .meme-content {
        height: 70px;
        width: 150px;
        display: flex;
        flex-direction: column;
        justify-content: space-evenly;
        align-items: center;
    }

    .meme-content .label {
        height: 35px;
        text-align: center;
    }

    .meme-content .icon {
        width: 21px;
        height: 21px;
    }
</style>