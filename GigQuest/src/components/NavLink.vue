<script setup>
  import { useRoute } from 'vue-router';

  const isActive = (path) => {
    const currPath = useRoute();
    return currPath.path === path
  }

</script>

<template>

<header class="bg-blue-400 flex justify-between px-12 py-3 items-center border-b border-gray-300">
    <img alt="Vue logo" class="rounded-full w-12 h-12" src="@/assets/img/gig-2.png"  width="125" height="125" />

    <div class="wrapper">

      <nav class="gap-4 flex items-center">
        <RouterLink to="/" :class="`${ isActive('/') ? 'bg-blue-600' : ''} text-white px-2 py-1 rounded-md hover:bg-blue-300 `">Home</RouterLink>
        <RouterLink to="/jobs" :class="`${ isActive('/jobs') ? 'bg-blue-600' : ''} text-white px-2 py-1 rounded-md hover:bg-blue-300`">Jobs</RouterLink>
        <RouterLink to="/add-jobs" :class="`${ isActive('/add-jobs') ? 'bg-blue-600' : ''} text-white px-2 py-1 rounded-md hover:bg-blue-300`">Add Jobs</RouterLink>

      </nav>
    </div>
  </header>

</template>

