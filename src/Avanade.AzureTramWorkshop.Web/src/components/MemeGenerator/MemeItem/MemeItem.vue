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
    height: 95px;
    width: 155px;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    align-items: center;
}

.meme-content .label {
    height: 35px;
    text-align: center;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    font-weight: 700;
    font-size: 20px;
    color: #858A90;
    text-transform: uppercase;
}

.meme-content .icon {
    width: 21px;
    height: 21px;
}
</style>