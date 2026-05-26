# Autonomous AI Hiring Agent 🚀

An enterprise-grade multi-agent autonomous AI recruitment runtime built using ASP.NET Core, OpenAI, semantic vector search, reflection intelligence, runtime telemetry, and autonomous orchestration.

---

# Overview

Autonomous AI Hiring Agent is a production-style AI orchestration platform that demonstrates:

- Multi-agent runtime execution
- AI-powered planning
- Semantic candidate retrieval
- OpenAI embeddings
- Reflection intelligence
- Runtime telemetry
- Autonomous orchestration
- Full-stack runtime dashboard

The platform simulates how next-generation autonomous recruitment systems can reason, search, reflect, and optimize hiring workflows using coordinated AI agents.

---

# Key Features

## Multi-Agent Runtime System

The platform executes autonomous workflows using specialized agents:

- PlannerAgent
- SearchAgent
- ReflectionAgent
- MemoryAgent

Each agent contributes independently to runtime cognition and orchestration.

---

## AI-Powered Planning

The runtime uses OpenAI to:

- Analyze recruiter intent
- Detect hiring objectives
- Extract required skills
- Generate runtime planning intelligence

---

## Semantic Vector Search

Implements embedding-based candidate retrieval using:

- OpenAI Embeddings
- Vector similarity scoring
- Semantic relevance matching
- Hybrid ranking logic

Supports intelligent retrieval beyond keyword matching.

---

## Reflection Intelligence

The runtime evaluates execution quality using autonomous reflection:

- Confidence scoring
- Strength detection
- Improvement analysis
- Runtime diagnostics

---

## Runtime Telemetry Dashboard

The frontend dashboard visualizes:

- Runtime execution metrics
- Multi-agent logs
- Reflection analysis
- Candidate retrieval
- Runtime warnings
- Telemetry traces

---

# Architecture

```text
User Request
    ↓
Runtime Dashboard
    ↓
RuntimeController
    ↓
RuntimeAgentOrchestrator
    ↓
+----------------------+
| PlannerAgent         |
| SearchAgent          |
| ReflectionAgent      |
| MemoryAgent          |
+----------------------+
    ↓
Semantic Vector Search
    ↓
OpenAI Embeddings
    ↓
Reflection Intelligence
    ↓
Runtime Telemetry
```

---

# Technology Stack

## Backend

- ASP.NET Core 9
- C#
- Dependency Injection
- MVC + API Hybrid Architecture

## AI Integration

- OpenAI GPT
- OpenAI Embeddings
- Reflection Intelligence
- Autonomous Planning

## Semantic Search

- Vector Similarity Search
- Embedding-Based Retrieval
- Hybrid Candidate Ranking

## Frontend

- Razor Views
- Tailwind CSS
- JavaScript
- Runtime Telemetry UI

---

# Project Structure

```text
├── Agents
├── Controllers
├── Interfaces
├── Memory
├── Models
├── Reflection
├── Repositories
├── Runtime
├── Services
├── Skills
├── VectorSearch
├── Views
└── Program.cs
```

---

# Runtime Flow

## 1. PlannerAgent

Analyzes recruiter intent and builds runtime planning intelligence.

## 2. SearchAgent

Executes semantic vector search against candidate embeddings.

## 3. ReflectionAgent

Evaluates runtime quality and confidence.

## 4. MemoryAgent

Persists runtime memory and telemetry.

---

# Runtime Dashboard

The dashboard provides:

- Autonomous runtime execution
- Reflection visualization
- Candidate result cards
- Runtime metrics
- Runtime logs
- Runtime warnings

---

# API Endpoint

## Execute Runtime

```http
POST /api/runtime/execute
```

### Example Request

```json
{
  "request": "Find senior AI backend engineers with vector database expertise"
}
```

### Example Response

```json
{
  "planner": "Technical recruitment workflow detected",
  "execution": "3 candidates retrieved and ranked",
  "executionMilliseconds": 1864
}
```

---

# Screenshots

## Runtime Dashboard

<img width="1199" height="409" alt="image" src="https://github.com/user-attachments/assets/18ae18c8-e8fa-4479-8d5e-ab25986113fa" />


## Runtime Logs

<img width="1165" height="714" alt="image" src="https://github.com/user-attachments/assets/54647cef-082d-4d33-9b12-8819a449e1e8" />


## Candidate Retrieval

 <img width="1155" height="353" alt="image" src="https://github.com/user-attachments/assets/bb48f3b8-a303-4442-8043-7bbdf063365d" />


---

# Setup Instructions

## Clone Repository

```bash
git clone https://github.com/BhaskarKommu/autonomous-ai-hiring-agent.git
```

---

## Open Solution

Open:

```text
AutonomousAIHiringAgent.sln
```

using Visual Studio 2022.

---

## Configure OpenAI API Key

Update:

```text
appsettings.json
```

```json
"OpenAISettings": {
  "ApiKey": "YOUR_API_KEY",
  "Model": "gpt-4.1-mini"
}
```

---

## Run Application

Press:

```text
F5
```

Dashboard opens at:

```text
https://localhost:7036/
```

Swagger available at:

```text
https://localhost:7036/swagger
```

---

# Future Improvements

- Adaptive learning memory
- Distributed agent orchestration
- pgvector database integration
- Redis runtime memory
- Real-time streaming telemetry
- AI interview orchestration
- Agent communication bus
- LangGraph integration

---

# Contest Submission

Built for the Hermes Agent Challenge.

This project demonstrates autonomous AI orchestration, semantic reasoning, runtime telemetry, and multi-agent cognition using production-style architecture.

---

# Author

## K Bhaskar

AI Engineer | .NET Developer | Autonomous Systems Builder

- ASP.NET Core
- AI Orchestration
- Semantic Search
- Vector Databases
- Runtime Intelligence

---
```
