<template>
    <div>
      <div v-for="post in posts" :key="post.id" class="card">
        <h3>{{ post.title }}</h3>
        <p>{{ post.content }}</p>
      </div>
    </div>
  </template>
  
  <script setup>
  import { ref, onMounted } from 'vue';
  import { getPosts } from '../../services/post.service';
  
  const posts = ref([]);
  
  onMounted(async () => {
    const res = await getPosts();
    posts.value = res.data;
  });
  </script>
  