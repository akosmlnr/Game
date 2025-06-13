using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000672 RID: 1650
	public class NPCSummonMenu : Singleton<NPCSummonMenu>
	{
		// Token: 0x06009178 RID: 37240 RVA: 0x0025E550 File Offset: 0x0025C750
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSummonMenu()
		{
			Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NPCSummonMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr);
			NPCSummonMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			NPCSummonMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "Canvas");
			NPCSummonMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "Container");
			NPCSummonMenu.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "EntryContainer");
			NPCSummonMenu.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "Entries");
			NPCSummonMenu.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "callback");
			NPCSummonMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681440);
			NPCSummonMenu.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681441);
			NPCSummonMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681442);
			NPCSummonMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681443);
			NPCSummonMenu.NativeMethodInfoPtr_Open_Public_Void_List_1_NPC_Action_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681444);
			NPCSummonMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681445);
			NPCSummonMenu.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681446);
			NPCSummonMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, 100681447);
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x06009179 RID: 37241 RVA: 0x0025E698 File Offset: 0x0025C898
		// (set) Token: 0x0600917A RID: 37242 RVA: 0x0025E6D4 File Offset: 0x0025C8D4
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x0025E714 File Offset: 0x0025C914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263942, XrefRangeEnd = 263959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSummonMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600917C RID: 37244 RVA: 0x0025E750 File Offset: 0x0025C950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263959, XrefRangeEnd = 263961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600917D RID: 37245 RVA: 0x0025E794 File Offset: 0x0025C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263961, XrefRangeEnd = 264037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<NPC> npcs, Il2CppSystem.Action<NPC> _callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcs);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_Open_Public_Void_List_1_NPC_Action_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x0025E7E8 File Offset: 0x0025C9E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264065, RefRangeEnd = 264068, XrefRangeStart = 264037, XrefRangeEnd = 264065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600917F RID: 37247 RVA: 0x0025E81C File Offset: 0x0025CA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264068, XrefRangeEnd = 264070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCSelected(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009180 RID: 37248 RVA: 0x0025E860 File Offset: 0x0025CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264070, XrefRangeEnd = 264073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSummonMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x00045D51 File Offset: 0x00043F51
		public NPCSummonMenu(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x06009182 RID: 37250 RVA: 0x0025E89C File Offset: 0x0025CA9C
		// (set) Token: 0x06009183 RID: 37251 RVA: 0x00045D5A File Offset: 0x00043F5A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x06009184 RID: 37252 RVA: 0x0025E8C4 File Offset: 0x0025CAC4
		// (set) Token: 0x06009185 RID: 37253 RVA: 0x00045D75 File Offset: 0x00043F75
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x06009186 RID: 37254 RVA: 0x0025E8F4 File Offset: 0x0025CAF4
		// (set) Token: 0x06009187 RID: 37255 RVA: 0x00045D94 File Offset: 0x00043F94
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x06009188 RID: 37256 RVA: 0x0025E924 File Offset: 0x0025CB24
		// (set) Token: 0x06009189 RID: 37257 RVA: 0x00045DB3 File Offset: 0x00043FB3
		public unsafe RectTransform EntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_EntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x0025E954 File Offset: 0x0025CB54
		// (set) Token: 0x0600918B RID: 37259 RVA: 0x00045DD2 File Offset: 0x00043FD2
		public unsafe Il2CppReferenceArray<RectTransform> Entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x0600918C RID: 37260 RVA: 0x0025E984 File Offset: 0x0025CB84
		// (set) Token: 0x0600918D RID: 37261 RVA: 0x00045DF1 File Offset: 0x00043FF1
		public unsafe Il2CppSystem.Action<NPC> callback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_callback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006274 RID: 25204
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006275 RID: 25205
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006276 RID: 25206
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006277 RID: 25207
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04006278 RID: 25208
		private static readonly System.IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04006279 RID: 25209
		private static readonly System.IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400627A RID: 25210
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400627B RID: 25211
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400627C RID: 25212
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400627D RID: 25213
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400627E RID: 25214
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_NPC_Action_1_NPC_0;

		// Token: 0x0400627F RID: 25215
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006280 RID: 25216
		private static readonly System.IntPtr NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0;

		// Token: 0x04006281 RID: 25217
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B81 RID: 2945
		[ObfuscatedName("ScheduleOne.UI.NPCSummonMenu+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD51 RID: 56657 RVA: 0x0034B69C File Offset: 0x0034989C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSummonMenu>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr);
				NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr, "npc");
				NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				NPCSummonMenu.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr, 100681448);
				NPCSummonMenu.__c__DisplayClass11_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr, 100681449);
			}

			// Token: 0x0600DD52 RID: 56658 RVA: 0x0034B718 File Offset: 0x00349918
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSummonMenu.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD53 RID: 56659 RVA: 0x0034B754 File Offset: 0x00349954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263940, XrefRangeEnd = 263942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSummonMenu.__c__DisplayClass11_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD54 RID: 56660 RVA: 0x0006B753 File Offset: 0x00069953
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700444C RID: 17484
			// (get) Token: 0x0600DD55 RID: 56661 RVA: 0x0034B788 File Offset: 0x00349988
			// (set) Token: 0x0600DD56 RID: 56662 RVA: 0x0006B75C File Offset: 0x0006995C
			public unsafe NPC npc
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr_npc);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700444D RID: 17485
			// (get) Token: 0x0600DD57 RID: 56663 RVA: 0x0034B7B8 File Offset: 0x003499B8
			// (set) Token: 0x0600DD58 RID: 56664 RVA: 0x0006B77B File Offset: 0x0006997B
			public unsafe NPCSummonMenu __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSummonMenu>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSummonMenu.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094C5 RID: 38085
			private static readonly System.IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x040094C6 RID: 38086
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094C7 RID: 38087
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094C8 RID: 38088
			private static readonly System.IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;
		}
	}
}
