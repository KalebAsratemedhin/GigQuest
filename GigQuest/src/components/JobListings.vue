<script setup>
import JobListing from './JobListing.vue';


</script>

<template>
    <div class="bg-blue-100 flex flex-col items-center ">
        <h1 class="text-blue-600 text-4xl py-4 font-bold">Browse Jobs</h1>
        <div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3  p-8 gap-4">

        <JobListing></JobListing>
        <JobListing></JobListing>
        <JobListing></JobListing>
        <JobListing></JobListing>



        </div>
    </div>
</template>