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
}

.meme-item {
    flex-grow: 1;
    height: 162px;
    display: flex;
    justify-content: center;
    align-items: center;
}
</style>