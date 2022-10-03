<script lang="ts">
import MemeItem from "./MemeItem/MemeItem.vue";
export default {
    data() {
        return {
            memes: [{}, {}, {}, {}, {}]
        }
    },
    components: { MemeItem }
}
</script>

<template>
    <div class="meme-generator-content">
        <div v-for="meme in memes" class="meme-item">
            <MemeItem></MemeItem>
        </div>
    </div>
</template>

<style scoped>
.meme-generator-content {
    background-image: url('@/assets/img/MEME_GENERATOR.png');
    width: 1449px;
    height: 178px;
    display: flex;
    flex-direction: row;
    align-items: end;
    position: relative;
}

.meme-item {
    flex-grow: 1;
    height: 162px;
    display: flex;
    justify-content: center;
    align-items: center;
    position: absolute;
}

.meme-item:nth-of-type(1) {
    left: 55px;
}

.meme-item:nth-of-type(2) {
    left: calc(55px + 297px);
}

.meme-item:nth-of-type(3) {
    left: calc(55px + 2*297px);
}

.meme-item:nth-of-type(4) {
    left: calc(55px + 3*297px);
}

.meme-item:nth-of-type(5) {
    left: calc(55px + 4*297px - 1px);
}
</style>