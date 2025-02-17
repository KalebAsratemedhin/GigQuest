<script setup>
    import { RouterLink } from 'vue-router';
    import Card from './Card.vue';
</script>
<template>
    <div class="flex flex-wrap gap-4 items-center justify-center h-96">
        <Card :bg="`bg-gray-200`">
            <div class="flex flex-col justify-between items-start">
                <h1 class="text-xl font-bold mb-2">For Freelancers</h1>
                <p class="text-sm mb-4 text-gray-700">Browse our jobs today and start your career.</p>
                <RouterLink to="/jobs" class="bg-gray-900 px-3 py-2 rounded-md text-white">Browse Jobs</RouterLink>
            </div>
        </Card>
        <Card :bg="`bg-blue-200`">
            <div class="flex flex-col justify-between items-start">
                <h1 class="text-xl font-bold mb-2 ">For Employers</h1>
                <p class="text-sm mb-4 text-gray-700">List your jobs to find the perfect frelancer for you.</p>
                <RouterLink to="/add-job" class="bg-blue-900 px-3 py-2 rounded-md text-white">Add Job</RouterLink>
            </div>
        </Card>

    </div>

</template>