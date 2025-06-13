using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002FE RID: 766
	public class ConversationLocation : MonoBehaviour
	{
		// Token: 0x060037BA RID: 14266 RVA: 0x001279C8 File Offset: 0x00125BC8
		// Note: this type is marked as 'beforefieldinit'.
		static ConversationLocation()
		{
			Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "ConversationLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr);
			ConversationLocation.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "StandPoints");
			ConversationLocation.NativeFieldInfoPtr_NPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "NPCs");
			ConversationLocation.NativeFieldInfoPtr_npcReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "npcReady");
			ConversationLocation.NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669731);
			ConversationLocation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669732);
			ConversationLocation.NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669733);
			ConversationLocation.NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669734);
			ConversationLocation.NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669735);
			ConversationLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100669736);
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x00127AAC File Offset: 0x00125CAC
		public unsafe bool NPCsReady
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144449, XrefRangeEnd = 144470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00127AE8 File Offset: 0x00125CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144470, XrefRangeEnd = 144494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00127B1C File Offset: 0x00125D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144494, XrefRangeEnd = 144502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetStandPoint(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00127B6C File Offset: 0x00125D6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 144515, RefRangeEnd = 144518, XrefRangeStart = 144502, XrefRangeEnd = 144515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPCReady(NPC npc, bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ready;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00127BBC File Offset: 0x00125DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144518, XrefRangeEnd = 144544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC GetOtherNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00127C0C File Offset: 0x00125E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144544, XrefRangeEnd = 144559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConversationLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x0001CFAA File Offset: 0x0001B1AA
		public ConversationLocation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x00127C48 File Offset: 0x00125E48
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x0001CFB3 File Offset: 0x0001B1B3
		public unsafe Il2CppReferenceArray<Transform> StandPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_StandPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x00127C78 File Offset: 0x00125E78
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x0001CFD2 File Offset: 0x0001B1D2
		public unsafe List<NPC> NPCs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_NPCs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_NPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x00127CA8 File Offset: 0x00125EA8
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x0001CFF1 File Offset: 0x0001B1F1
		public unsafe Dictionary<NPC, bool> npcReady
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_npcReady);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPC, bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_npcReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002478 RID: 9336
		private static readonly System.IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x04002479 RID: 9337
		private static readonly System.IntPtr NativeFieldInfoPtr_NPCs;

		// Token: 0x0400247A RID: 9338
		private static readonly System.IntPtr NativeFieldInfoPtr_npcReady;

		// Token: 0x0400247B RID: 9339
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0;

		// Token: 0x0400247C RID: 9340
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400247D RID: 9341
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0;

		// Token: 0x0400247E RID: 9342
		private static readonly System.IntPtr NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0;

		// Token: 0x0400247F RID: 9343
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0;

		// Token: 0x04002480 RID: 9344
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000978 RID: 2424
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.ConversationLocation+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CBCB RID: 52171 RVA: 0x0031976C File Offset: 0x0031796C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr);
				ConversationLocation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, "<>9");
				ConversationLocation.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, "<>9__3_0");
				ConversationLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, 100669738);
				ConversationLocation.__c.NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, 100669739);
			}

			// Token: 0x0600CBCC RID: 52172 RVA: 0x003197E8 File Offset: 0x003179E8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CBCD RID: 52173 RVA: 0x00319824 File Offset: 0x00317A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144444, XrefRangeEnd = 144445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_NPCsReady_b__3_0(KeyValuePair<NPC, bool> npcReady)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(npcReady));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c.NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBCE RID: 52174 RVA: 0x00062E09 File Offset: 0x00061009
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F2B RID: 16171
			// (get) Token: 0x0600CBCF RID: 52175 RVA: 0x00319878 File Offset: 0x00317A78
			// (set) Token: 0x0600CBD0 RID: 52176 RVA: 0x00062E12 File Offset: 0x00061012
			public unsafe static ConversationLocation.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConversationLocation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConversationLocation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConversationLocation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2C RID: 16172
			// (get) Token: 0x0600CBD1 RID: 52177 RVA: 0x003198A0 File Offset: 0x00317AA0
			// (set) Token: 0x0600CBD2 RID: 52178 RVA: 0x00062E24 File Offset: 0x00061024
			public unsafe static Il2CppSystem.Func<KeyValuePair<NPC, bool>, bool> __9__3_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConversationLocation.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KeyValuePair<NPC, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConversationLocation.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089F9 RID: 35321
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040089FA RID: 35322
			private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040089FB RID: 35323
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089FC RID: 35324
			private static readonly System.IntPtr NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0;
		}

		// Token: 0x02000979 RID: 2425
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.ConversationLocation+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBD3 RID: 52179 RVA: 0x003198C8 File Offset: 0x00317AC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr);
				ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, "npc");
				ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, 100669740);
				ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, 100669741);
			}

			// Token: 0x0600CBD4 RID: 52180 RVA: 0x00319930 File Offset: 0x00317B30
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CBD5 RID: 52181 RVA: 0x0031996C File Offset: 0x00317B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144445, XrefRangeEnd = 144449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOtherNPC_b__0(NPC otherNPC)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherNPC);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBD6 RID: 52182 RVA: 0x00062E36 File Offset: 0x00061036
			public __c__DisplayClass8_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F2D RID: 16173
			// (get) Token: 0x0600CBD7 RID: 52183 RVA: 0x003199BC File Offset: 0x00317BBC
			// (set) Token: 0x0600CBD8 RID: 52184 RVA: 0x00062E3F File Offset: 0x0006103F
			public unsafe NPC npc
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089FD RID: 35325
			private static readonly System.IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x040089FE RID: 35326
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089FF RID: 35327
			private static readonly System.IntPtr NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0;
		}
	}
}
