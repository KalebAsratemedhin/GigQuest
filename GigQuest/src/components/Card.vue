<script setup>

import { defineProps } from 'vue';

defineProps({
    bg: String
})
</script>

<template>

    <div :class="`${bg} p-3 rounded-md w-72 h-40 `">
        <slot></slot>

    </div>
</template>