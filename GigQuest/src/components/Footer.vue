<script setup>
    import { RouterLink } from 'vue-router'

</script>
<template>
    <footer class="flex justify-around text-gray-400 py-8 bg-gray-900">
        <div>
            <p>GigQuest</p>
            <p>&copy;copyrights reserved</p>


        </div>
        <div class="flex flex-col">
            <RouterLink to="/about" class="hover:text-white text-gray-400">About</RouterLink>
            <RouterLink to="/" class="hover:text-white text-gray-400">Home</RouterLink>
            <RouterLink to="/contact" class="hover:text-white text-gray-400">Contact</RouterLink>


        </div>

    </footer>
</template>