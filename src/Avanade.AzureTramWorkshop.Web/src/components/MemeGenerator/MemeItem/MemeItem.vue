<script setup lang="ts">
import { watch } from "vue";
import store from "@/store";
import DiodeOff from "../../shared/Icons/DiodeOff.vue";
import DiodeOn from "../../shared/Icons/DiodeOn.vue"

const props = defineProps({
    index: Number,
    label: String,
})

const emits = defineEmits(['onDiodeClick'])

watch(() => store.getters['meme/isIndexUnlocked'](props.index), () => {
    emits('onDiodeClick');
})
</script>

<template>
    <div class="meme-content">
        <div class="label">{{ label }}</div>
        <div class="icon">
            <DiodeOn v-if="store.getters['meme/isIndexUnlocked'](index)" @click="$emit('onDiodeClick')" class="link"></DiodeOn>
            <DiodeOff v-else></DiodeOff>
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

.link {
    cursor: pointer;
}
</style>