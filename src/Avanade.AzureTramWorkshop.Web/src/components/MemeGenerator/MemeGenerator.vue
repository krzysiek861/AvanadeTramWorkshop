<script lang="ts">
import store from "@/store";
import MemeItem from "./MemeItem/MemeItem.vue";
import Modal from "../shared/Modal.vue";
export default {
    data() {
        return {
            memes: [
                { label: "Good work!" },
                { label: "Fantastic!" },
                { label: "Well done!" },
                { label: "Awesome!" },
                { label: "Unbelievable!" }
            ],
            index: 0,
            isModalVisible: false,
        }
    },
    methods: {
        closeModal() {
            this.isModalVisible = false;
        },
        showModal(index:number) {
            this.index = index;
            this.isModalVisible = true;
        },
        getFileName() {
            return store.getters['meme/getFileName'](this.index);
        }
    },
    components: { MemeItem, Modal }
}
</script>

<template>
    <Modal v-show="isModalVisible" @close="closeModal()" :file="getFileName()" />
    <div class="meme-generator-content">
        <div v-for="(item, index) in memes" v-bind:key="index" class="meme-item">
            <MemeItem :label="item.label" :index="index" v-on:on-diode-click="showModal(index)"></MemeItem>
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