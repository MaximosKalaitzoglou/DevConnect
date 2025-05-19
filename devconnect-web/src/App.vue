<template>
  <div id="app">
    <header>
      <h1>DevConnect</h1>
      <nav>
        <router-link to="/">Home</router-link>
        <router-link to="/feed">Feed</router-link>
      </nav>
    </header>
    
    <main>
      <router-view /> <!-- Renders matched component -->
    </main>
  </div>
</template>

<script setup>
// No imports needed here if using <router-view />
</script>

<style scoped>
/* Basic styling example */
header {
  background-color: #1e1e2f;
  padding: 1rem;
  color: #fff;
  display: flex;
  justify-content: space-between;
  align-items: center;
}

nav a {
  margin: 0 1rem;
  color: #90cdf4;
  text-decoration: none;
}

nav a.router-link-active {
  font-weight: bold;
  text-decoration: underline;
}

main {
  padding: 2rem;
  font-family: sans-serif;
}
</style>
