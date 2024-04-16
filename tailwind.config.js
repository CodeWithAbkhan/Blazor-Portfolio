/** @type {import('tailwindcss').Config} */
module.exports = {
  darkMode: "class",             
  content: ['./**/*.{razor,html}'],
  theme: {
    extend: {
      fontWeight: {
        semibold: 700,
       },
    },
    container: {
      center: true,
      padding: "2rem",
      screens: {
       "2xl": "1400px",
      },
     },
  },
  plugins: ['@tailwindcss/typography'],
}

