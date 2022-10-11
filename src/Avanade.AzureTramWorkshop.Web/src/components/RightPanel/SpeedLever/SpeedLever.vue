<script lang="ts">
export default {
    data() {
        return { accelerate: false }
    },
    methods: {
        toggleAcceleration() {
            this.accelerate = !this.accelerate;
        }
    }
}
</script>

<template>
    <div class="speed-lever-content">
        <div class="handle" :class="{acceleration: accelerate, deceleration: !accelerate}"
            @click="toggleAcceleration()"></div>
    </div>
</template>

<style scoped>
.speed-lever-content {
    width: 338px;
    height: 174px;
    background-image: url('@/assets/img/DZWIGNIA_BG.png');
    margin-top: 16px;
    position: relative;
}

.handle {
    position: absolute;
    width: 119px;
    height: 83px;
}

.handle.acceleration {
    background-image: url('@/assets/img/DZWIGNIA_TOP.png');
    right: -10px;
    top: 25px;
}

.handle.deceleration {
    background-image: url('@/assets/img/DZWIGNIA_BOTTOM.png');
    right: -10px;
    bottom: 22px;
}
</style>