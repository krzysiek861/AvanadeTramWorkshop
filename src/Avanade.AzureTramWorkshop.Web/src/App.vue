<script setup lang="ts">
import MainCocpit from "./components/MainCocpit/MainCocpit.vue";
</script>

<template>
    <div class="main">
        <div class="first-column">
            <div class="main-cocpit">
                <MainCocpit></MainCocpit>
            </div>
            <div class="meme-generator"></div>
        </div>
        <div class="second-column"></div>
    </div>
</template>

<style scoped>
.main {
    display: flex;
    flex-direction: row;
    width: fit-content;
}

.first-column {
    display: flex;
    flex-direction: column;
}

.main-cocpit {
    height: 876px;
    width: 1537px;
    background-image: url('./assets/img/SCREEN_BG.png');
    position: relative;
}

.meme-generator {
    height: 204px;
    width: 1537px;
    background-image: url('./assets/img/MEME_GENERATOR_BG.png');
}

.second-column {
    width: 383px;
    height: 1080px;
    background-image: url('./assets/img/RIGHT_PANEL_BG.png');
}
</style>
