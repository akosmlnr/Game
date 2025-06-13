using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F6 RID: 1782
	public class NPCSelector : MonoBehaviour
	{
		// Token: 0x06009F55 RID: 40789 RVA: 0x002878D0 File Offset: 0x00285AD0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSelector()
		{
			Il2CppClassPointerStore<NPCSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NPCSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr);
			NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "SELECTION_RANGE");
			NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			NPCSelector.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "DetectionMask");
			NPCSelector.NativeFieldInfoPtr_HoverOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "HoverOutlineColor");
			NPCSelector.NativeFieldInfoPtr_TypeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "TypeRequirement");
			NPCSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "callback");
			NPCSelector.NativeFieldInfoPtr_hoveredNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "hoveredNPC");
			NPCSelector.NativeFieldInfoPtr_highlightedNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, "highlightedNPC");
			NPCSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682958);
			NPCSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682959);
			NPCSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682960);
			NPCSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682961);
			NPCSelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682962);
			NPCSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682963);
			NPCSelector.NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682964);
			NPCSelector.NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682965);
			NPCSelector.NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682966);
			NPCSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682967);
			NPCSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682968);
			NPCSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr, 100682969);
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x06009F56 RID: 40790 RVA: 0x00287A90 File Offset: 0x00285C90
		// (set) Token: 0x06009F57 RID: 40791 RVA: 0x00287ACC File Offset: 0x00285CCC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x00287B0C File Offset: 0x00285D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282814, XrefRangeEnd = 282836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F59 RID: 40793 RVA: 0x00287B40 File Offset: 0x00285D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282836, XrefRangeEnd = 282861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(string selectionTitle, Il2CppSystem.Type typeRequirement, Il2CppSystem.Action<NPC> _callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeRequirement);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F5A RID: 40794 RVA: 0x00287BB4 File Offset: 0x00285DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282861, XrefRangeEnd = 282899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(bool returnToClipboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref returnToClipboard;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x00287C00 File Offset: 0x00285E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282899, XrefRangeEnd = 282934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F5C RID: 40796 RVA: 0x00287C34 File Offset: 0x00285E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282934, XrefRangeEnd = 282940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC GetHoveredNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
		}

		// Token: 0x06009F5D RID: 40797 RVA: 0x00287C74 File Offset: 0x00285E74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 282945, RefRangeEnd = 282949, XrefRangeStart = 282940, XrefRangeEnd = 282945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNPCTypeValid(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F5E RID: 40798 RVA: 0x00287CC4 File Offset: 0x00285EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282949, XrefRangeEnd = 282950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCClicked(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x00287D08 File Offset: 0x00285F08
		[CallerCount(0)]
		public unsafe void ClipboardClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F60 RID: 40800 RVA: 0x00287D3C File Offset: 0x00285F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282950, XrefRangeEnd = 282951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F61 RID: 40801 RVA: 0x00287D80 File Offset: 0x00285F80
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F62 RID: 40802 RVA: 0x0004DE54 File Offset: 0x0004C054
		public NPCSelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x06009F63 RID: 40803 RVA: 0x00287DBC File Offset: 0x00285FBC
		// (set) Token: 0x06009F64 RID: 40804 RVA: 0x0004DE5D File Offset: 0x0004C05D
		public unsafe static float SELECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x06009F65 RID: 40805 RVA: 0x00287DD8 File Offset: 0x00285FD8
		// (set) Token: 0x06009F66 RID: 40806 RVA: 0x0004DE6B File Offset: 0x0004C06B
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06009F67 RID: 40807 RVA: 0x00287E00 File Offset: 0x00286000
		// (set) Token: 0x06009F68 RID: 40808 RVA: 0x0004DE86 File Offset: 0x0004C086
		public unsafe LayerMask DetectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x06009F69 RID: 40809 RVA: 0x00287E28 File Offset: 0x00286028
		// (set) Token: 0x06009F6A RID: 40810 RVA: 0x0004DEA1 File Offset: 0x0004C0A1
		public unsafe Color HoverOutlineColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_HoverOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_HoverOutlineColor)) = value;
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x06009F6B RID: 40811 RVA: 0x00287E50 File Offset: 0x00286050
		// (set) Token: 0x06009F6C RID: 40812 RVA: 0x0004DEBC File Offset: 0x0004C0BC
		public unsafe Il2CppSystem.Type TypeRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_TypeRequirement);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_TypeRequirement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x06009F6D RID: 40813 RVA: 0x00287E80 File Offset: 0x00286080
		// (set) Token: 0x06009F6E RID: 40814 RVA: 0x0004DEDB File Offset: 0x0004C0DB
		public unsafe Il2CppSystem.Action<NPC> callback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_callback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x06009F6F RID: 40815 RVA: 0x00287EB0 File Offset: 0x002860B0
		// (set) Token: 0x06009F70 RID: 40816 RVA: 0x0004DEFA File Offset: 0x0004C0FA
		public unsafe NPC hoveredNPC
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_hoveredNPC);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_hoveredNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x06009F71 RID: 40817 RVA: 0x00287EE0 File Offset: 0x002860E0
		// (set) Token: 0x06009F72 RID: 40818 RVA: 0x0004DF19 File Offset: 0x0004C119
		public unsafe NPC highlightedNPC
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_highlightedNPC);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSelector.NativeFieldInfoPtr_highlightedNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B0A RID: 27402
		private static readonly System.IntPtr NativeFieldInfoPtr_SELECTION_RANGE;

		// Token: 0x04006B0B RID: 27403
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006B0C RID: 27404
		private static readonly System.IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04006B0D RID: 27405
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverOutlineColor;

		// Token: 0x04006B0E RID: 27406
		private static readonly System.IntPtr NativeFieldInfoPtr_TypeRequirement;

		// Token: 0x04006B0F RID: 27407
		private static readonly System.IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04006B10 RID: 27408
		private static readonly System.IntPtr NativeFieldInfoPtr_hoveredNPC;

		// Token: 0x04006B11 RID: 27409
		private static readonly System.IntPtr NativeFieldInfoPtr_highlightedNPC;

		// Token: 0x04006B12 RID: 27410
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006B13 RID: 27411
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006B14 RID: 27412
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006B15 RID: 27413
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_Type_Action_1_NPC_0;

		// Token: 0x04006B16 RID: 27414
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006B17 RID: 27415
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006B18 RID: 27416
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredNPC_Private_NPC_0;

		// Token: 0x04006B19 RID: 27417
		private static readonly System.IntPtr NativeMethodInfoPtr_IsNPCTypeValid_Public_Boolean_NPC_0;

		// Token: 0x04006B1A RID: 27418
		private static readonly System.IntPtr NativeMethodInfoPtr_NPCClicked_Public_Void_NPC_0;

		// Token: 0x04006B1B RID: 27419
		private static readonly System.IntPtr NativeMethodInfoPtr_ClipboardClosed_Private_Void_0;

		// Token: 0x04006B1C RID: 27420
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006B1D RID: 27421
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
