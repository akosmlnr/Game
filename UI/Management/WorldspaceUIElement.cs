using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x02000707 RID: 1799
	public class WorldspaceUIElement : MonoBehaviour
	{
		// Token: 0x0600A08F RID: 41103 RVA: 0x0028B838 File Offset: 0x00289A38
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspaceUIElement()
		{
			Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "WorldspaceUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr);
			WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "TRANSITION_TIME");
			WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<IsEnabled>k__BackingField");
			WorldspaceUIElement.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "RectTransform");
			WorldspaceUIElement.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "Container");
			WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "TitleLabel");
			WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "AssignedWorkerDisplay");
			WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "scaleRoutine");
			WorldspaceUIElement.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683085);
			WorldspaceUIElement.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683086);
			WorldspaceUIElement.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683087);
			WorldspaceUIElement.NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683088);
			WorldspaceUIElement.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683089);
			WorldspaceUIElement.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683090);
			WorldspaceUIElement.NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683091);
			WorldspaceUIElement.NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683092);
			WorldspaceUIElement.NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683093);
			WorldspaceUIElement.NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683094);
			WorldspaceUIElement.NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683095);
			WorldspaceUIElement.NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683096);
			WorldspaceUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100683097);
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x0600A090 RID: 41104 RVA: 0x0028B9F8 File Offset: 0x00289BF8
		// (set) Token: 0x0600A091 RID: 41105 RVA: 0x0028BA34 File Offset: 0x00289C34
		public unsafe bool IsEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x0600A092 RID: 41106 RVA: 0x0028BA74 File Offset: 0x00289C74
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284231, XrefRangeEnd = 284234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x0028BAB0 File Offset: 0x00289CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284234, XrefRangeEnd = 284248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x0028BAEC File Offset: 0x00289CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284248, XrefRangeEnd = 284268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hide(Il2CppSystem.Action callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x0028BB3C File Offset: 0x00289D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284268, XrefRangeEnd = 284273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x0028BB78 File Offset: 0x00289D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284287, RefRangeEnd = 284288, XrefRangeStart = 284273, XrefRangeEnd = 284287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition(Vector3 worldSpacePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldSpacePosition;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x0028BBB8 File Offset: 0x00289DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284288, XrefRangeEnd = 284296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInternalScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref scale;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x0028BC04 File Offset: 0x00289E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284325, RefRangeEnd = 284327, XrefRangeStart = 284296, XrefRangeEnd = 284325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale, Il2CppSystem.Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref scale;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x0028BC54 File Offset: 0x00289E54
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x0028BC90 File Offset: 0x00289E90
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x0028BCCC File Offset: 0x00289ECC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 284335, RefRangeEnd = 284343, XrefRangeStart = 284327, XrefRangeEnd = 284335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssignedNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A09C RID: 41116 RVA: 0x0028BD10 File Offset: 0x00289F10
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspaceUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A09D RID: 41117 RVA: 0x0004E883 File Offset: 0x0004CA83
		public WorldspaceUIElement(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0600A09E RID: 41118 RVA: 0x0028BD4C File Offset: 0x00289F4C
		// (set) Token: 0x0600A09F RID: 41119 RVA: 0x0004E88C File Offset: 0x0004CA8C
		public unsafe static float TRANSITION_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME, (void*)(&value));
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x0028BD68 File Offset: 0x00289F68
		// (set) Token: 0x0600A0A1 RID: 41121 RVA: 0x0004E89A File Offset: 0x0004CA9A
		public unsafe bool _IsEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0600A0A2 RID: 41122 RVA: 0x0028BD90 File Offset: 0x00289F90
		// (set) Token: 0x0600A0A3 RID: 41123 RVA: 0x0004E8B5 File Offset: 0x0004CAB5
		public unsafe RectTransform RectTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_RectTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0600A0A4 RID: 41124 RVA: 0x0028BDC0 File Offset: 0x00289FC0
		// (set) Token: 0x0600A0A5 RID: 41125 RVA: 0x0004E8D4 File Offset: 0x0004CAD4
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x0028BDF0 File Offset: 0x00289FF0
		// (set) Token: 0x0600A0A7 RID: 41127 RVA: 0x0004E8F3 File Offset: 0x0004CAF3
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x0600A0A8 RID: 41128 RVA: 0x0028BE20 File Offset: 0x0028A020
		// (set) Token: 0x0600A0A9 RID: 41129 RVA: 0x0004E912 File Offset: 0x0004CB12
		public unsafe AssignedWorkerDisplay AssignedWorkerDisplay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignedWorkerDisplay>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x0600A0AA RID: 41130 RVA: 0x0028BE50 File Offset: 0x0028A050
		// (set) Token: 0x0600A0AB RID: 41131 RVA: 0x0004E931 File Offset: 0x0004CB31
		public unsafe Coroutine scaleRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BCF RID: 27599
		private static readonly System.IntPtr NativeFieldInfoPtr_TRANSITION_TIME;

		// Token: 0x04006BD0 RID: 27600
		private static readonly System.IntPtr NativeFieldInfoPtr__IsEnabled_k__BackingField;

		// Token: 0x04006BD1 RID: 27601
		private static readonly System.IntPtr NativeFieldInfoPtr_RectTransform;

		// Token: 0x04006BD2 RID: 27602
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006BD3 RID: 27603
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006BD4 RID: 27604
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignedWorkerDisplay;

		// Token: 0x04006BD5 RID: 27605
		private static readonly System.IntPtr NativeFieldInfoPtr_scaleRoutine;

		// Token: 0x04006BD6 RID: 27606
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x04006BD7 RID: 27607
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006BD8 RID: 27608
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04006BD9 RID: 27609
		private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0;

		// Token: 0x04006BDA RID: 27610
		private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0;

		// Token: 0x04006BDB RID: 27611
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04006BDC RID: 27612
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0;

		// Token: 0x04006BDD RID: 27613
		private static readonly System.IntPtr NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0;

		// Token: 0x04006BDE RID: 27614
		private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0;

		// Token: 0x04006BDF RID: 27615
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0;

		// Token: 0x04006BE0 RID: 27616
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0;

		// Token: 0x04006BE1 RID: 27617
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0;

		// Token: 0x04006BE2 RID: 27618
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BEA RID: 3050
		[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E17B RID: 57723 RVA: 0x003577FC File Offset: 0x003559FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, "callback");
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100683098);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Hide_b__0_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100683099);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100683100);
			}

			// Token: 0x0600E17C RID: 57724 RVA: 0x0035788C File Offset: 0x00355A8C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E17D RID: 57725 RVA: 0x003578C8 File Offset: 0x00355AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284206, XrefRangeEnd = 284208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Hide_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Hide_b__0_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E17E RID: 57726 RVA: 0x003578FC File Offset: 0x00355AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E17F RID: 57727 RVA: 0x0006D802 File Offset: 0x0006BA02
			public __c__DisplayClass13_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004590 RID: 17808
			// (get) Token: 0x0600E180 RID: 57728 RVA: 0x00357930 File Offset: 0x00355B30
			// (set) Token: 0x0600E181 RID: 57729 RVA: 0x0006D80B File Offset: 0x0006BA0B
			public unsafe WorldspaceUIElement __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004591 RID: 17809
			// (get) Token: 0x0600E182 RID: 57730 RVA: 0x00357960 File Offset: 0x00355B60
			// (set) Token: 0x0600E183 RID: 57731 RVA: 0x0006D82A File Offset: 0x0006BA2A
			public unsafe Il2CppSystem.Action callback
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009733 RID: 38707
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009734 RID: 38708
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04009735 RID: 38709
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009736 RID: 38710
			private static readonly System.IntPtr NativeMethodInfoPtr__Hide_b__0_Internal_Void_1;

			// Token: 0x04009737 RID: 38711
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000BEB RID: 3051
		[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E184 RID: 57732 RVA: 0x00357990 File Offset: 0x00355B90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr);
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "startScale");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "scale");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "lerpTime");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "callback");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, 100683101);
				WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, 100683102);
			}

			// Token: 0x0600E185 RID: 57733 RVA: 0x00357A48 File Offset: 0x00355C48
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E186 RID: 57734 RVA: 0x00357A84 File Offset: 0x00355C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284226, XrefRangeEnd = 284231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E187 RID: 57735 RVA: 0x0006D849 File Offset: 0x0006BA49
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004592 RID: 17810
			// (get) Token: 0x0600E188 RID: 57736 RVA: 0x00357AC4 File Offset: 0x00355CC4
			// (set) Token: 0x0600E189 RID: 57737 RVA: 0x0006D852 File Offset: 0x0006BA52
			public unsafe WorldspaceUIElement __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004593 RID: 17811
			// (get) Token: 0x0600E18A RID: 57738 RVA: 0x00357AF4 File Offset: 0x00355CF4
			// (set) Token: 0x0600E18B RID: 57739 RVA: 0x0006D871 File Offset: 0x0006BA71
			public unsafe float startScale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17004594 RID: 17812
			// (get) Token: 0x0600E18C RID: 57740 RVA: 0x00357B1C File Offset: 0x00355D1C
			// (set) Token: 0x0600E18D RID: 57741 RVA: 0x0006D88C File Offset: 0x0006BA8C
			public unsafe float scale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x17004595 RID: 17813
			// (get) Token: 0x0600E18E RID: 57742 RVA: 0x00357B44 File Offset: 0x00355D44
			// (set) Token: 0x0600E18F RID: 57743 RVA: 0x0006D8A7 File Offset: 0x0006BAA7
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004596 RID: 17814
			// (get) Token: 0x0600E190 RID: 57744 RVA: 0x00357B6C File Offset: 0x00355D6C
			// (set) Token: 0x0600E191 RID: 57745 RVA: 0x0006D8C2 File Offset: 0x0006BAC2
			public unsafe Il2CppSystem.Action callback
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009738 RID: 38712
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009739 RID: 38713
			private static readonly System.IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x0400973A RID: 38714
			private static readonly System.IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x0400973B RID: 38715
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400973C RID: 38716
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400973D RID: 38717
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400973E RID: 38718
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CDE RID: 3294
			[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass17_0+<<SetScale>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EC2A RID: 60458 RVA: 0x0037639C File Offset: 0x0037459C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "<<SetScale>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100683103);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100683104);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100683105);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100683106);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100683107);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100683108);
				}

				// Token: 0x0600EC2B RID: 60459 RVA: 0x00376490 File Offset: 0x00374690
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC2C RID: 60460 RVA: 0x003764D8 File Offset: 0x003746D8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC2D RID: 60461 RVA: 0x0037650C File Offset: 0x0037470C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284208, XrefRangeEnd = 284221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004937 RID: 18743
				// (get) Token: 0x0600EC2E RID: 60462 RVA: 0x00376548 File Offset: 0x00374748
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC2F RID: 60463 RVA: 0x00376588 File Offset: 0x00374788
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284221, XrefRangeEnd = 284226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004938 RID: 18744
				// (get) Token: 0x0600EC30 RID: 60464 RVA: 0x003765BC File Offset: 0x003747BC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC31 RID: 60465 RVA: 0x00072F41 File Offset: 0x00071141
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004933 RID: 18739
				// (get) Token: 0x0600EC32 RID: 60466 RVA: 0x003765FC File Offset: 0x003747FC
				// (set) Token: 0x0600EC33 RID: 60467 RVA: 0x00072F4A File Offset: 0x0007114A
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004934 RID: 18740
				// (get) Token: 0x0600EC34 RID: 60468 RVA: 0x00376624 File Offset: 0x00374824
				// (set) Token: 0x0600EC35 RID: 60469 RVA: 0x00072F65 File Offset: 0x00071165
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004935 RID: 18741
				// (get) Token: 0x0600EC36 RID: 60470 RVA: 0x00376654 File Offset: 0x00374854
				// (set) Token: 0x0600EC37 RID: 60471 RVA: 0x00072F84 File Offset: 0x00071184
				public unsafe WorldspaceUIElement.__c__DisplayClass17_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004936 RID: 18742
				// (get) Token: 0x0600EC38 RID: 60472 RVA: 0x00376684 File Offset: 0x00374884
				// (set) Token: 0x0600EC39 RID: 60473 RVA: 0x00072FA3 File Offset: 0x000711A3
				public unsafe float _i_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009DE3 RID: 40419
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009DE4 RID: 40420
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009DE5 RID: 40421
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009DE6 RID: 40422
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009DE7 RID: 40423
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009DE8 RID: 40424
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DE9 RID: 40425
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009DEA RID: 40426
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009DEB RID: 40427
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DEC RID: 40428
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
