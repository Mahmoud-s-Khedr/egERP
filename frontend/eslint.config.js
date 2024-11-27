import globals from "globals";
import pluginJs from "@eslint/js";
import pluginReact from "eslint-plugin-react";


/** @type {import('eslint').Linter.Config[]} */
export default [
  {files: ["**/*.{js,mjs,cjs,jsx}"]},
  {languageOptions: { globals: globals.browser }},
  pluginJs.configs.recommended,
  pluginReact.configs.flat.recommended,
  {
    "extends": ["eslint:recommended", "plugin:prettier/recommended"],
    "plugins": ["prettier"],
    "rules": {
      "prettier/prettier": "error"
    },
    "prettier": {
      "printWidth": 120,
      "tabWidth": 2,
      "useTabs": false,
      "semi": true,
      "singleQuote": true,
      "trailingComma": "all",
      "bracketSpacing": true,
      "jsxBracketSameLine": true,
      "arrowParens": "always"
    }
  }
];