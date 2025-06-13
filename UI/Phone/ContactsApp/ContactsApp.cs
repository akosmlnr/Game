using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x020006DA RID: 1754
	public class ContactsApp : App<ContactsApp>
	{
		// Token: 0x06009D29 RID: 40233 RVA: 0x00281048 File Offset: 0x0027F248
		// Note: this type is marked as 'beforefieldinit'.
		static ContactsApp()
		{
			Il2CppClassPointerStore<ContactsApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ContactsApp", "ContactsApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr);
			ContactsApp.NativeFieldInfoPtr_SelectedRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectedRegion");
			ContactsApp.NativeFieldInfoPtr_RegionDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionDict");
			ContactsApp.NativeFieldInfoPtr_CirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "CirclesContainer");
			ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "DemoCirclesContainer");
			ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "TutorialCirclesContainer");
			ContactsApp.NativeFieldInfoPtr_ConnectionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ConnectionsContainer");
			ContactsApp.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ContentRect");
			ContactsApp.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectionIndicator");
			ContactsApp.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "DetailPanel");
			ContactsApp.NativeFieldInfoPtr_RegionUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionUIs");
			ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionSelectionContainer");
			ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionSelectionIndicator");
			ContactsApp.NativeFieldInfoPtr_LockedRegionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "LockedRegionContainer");
			ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionRankRequirementLabel");
			ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectedRegionIcon");
			ContactsApp.NativeFieldInfoPtr_ConnectionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ConnectionPrefab");
			ContactsApp.NativeFieldInfoPtr_RelationCircles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RelationCircles");
			ContactsApp.NativeFieldInfoPtr_contentMoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "contentMoveRoutine");
			ContactsApp.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "connections");
			ContactsApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682730);
			ContactsApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682731);
			ContactsApp.NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682732);
			ContactsApp.NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682733);
			ContactsApp.NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682734);
			ContactsApp.NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682735);
			ContactsApp.NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682736);
			ContactsApp.NativeMethodInfoPtr_StopContentMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682737);
			ContactsApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682738);
			ContactsApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100682739);
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x002812BC File Offset: 0x0027F4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279293, XrefRangeEnd = 279566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D2B RID: 40235 RVA: 0x002812F8 File Offset: 0x0027F4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279566, XrefRangeEnd = 279590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D2C RID: 40236 RVA: 0x00281334 File Offset: 0x0027F534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279605, RefRangeEnd = 279607, XrefRangeStart = 279590, XrefRangeEnd = 279605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationCircle GetRelationCircle(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
		}

		// Token: 0x06009D2D RID: 40237 RVA: 0x00281384 File Offset: 0x0027F584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279607, XrefRangeEnd = 279611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CircleClicked(RelationCircle circ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(circ);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D2E RID: 40238 RVA: 0x002813C8 File Offset: 0x0027F5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(RelationCircle circ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(circ);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D2F RID: 40239 RVA: 0x0028140C File Offset: 0x0027F60C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279644, RefRangeEnd = 279646, XrefRangeStart = 279611, XrefRangeEnd = 279644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedRegion(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref region;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x0028144C File Offset: 0x0027F64C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279661, RefRangeEnd = 279668, XrefRangeStart = 279646, XrefRangeEnd = 279661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZoomToRect(RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D31 RID: 40241 RVA: 0x00281490 File Offset: 0x0027F690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279668, XrefRangeEnd = 279669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopContentMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_StopContentMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D32 RID: 40242 RVA: 0x002814C4 File Offset: 0x0027F6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279669, XrefRangeEnd = 279687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x00281510 File Offset: 0x0027F710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279687, XrefRangeEnd = 279714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactsApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x0004C9DA File Offset: 0x0004ABDA
		public ContactsApp(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x06009D35 RID: 40245 RVA: 0x0028154C File Offset: 0x0027F74C
		// (set) Token: 0x06009D36 RID: 40246 RVA: 0x0004C9E3 File Offset: 0x0004ABE3
		public unsafe EMapRegion SelectedRegion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegion)) = value;
			}
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x06009D37 RID: 40247 RVA: 0x00281574 File Offset: 0x0027F774
		// (set) Token: 0x06009D38 RID: 40248 RVA: 0x0004C9FE File Offset: 0x0004ABFE
		public unsafe Dictionary<EMapRegion, ContactsApp.RegionUI> RegionDict
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionDict);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EMapRegion, ContactsApp.RegionUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x06009D39 RID: 40249 RVA: 0x002815A4 File Offset: 0x0027F7A4
		// (set) Token: 0x06009D3A RID: 40250 RVA: 0x0004CA1D File Offset: 0x0004AC1D
		public unsafe RectTransform CirclesContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_CirclesContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_CirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x06009D3B RID: 40251 RVA: 0x002815D4 File Offset: 0x0027F7D4
		// (set) Token: 0x06009D3C RID: 40252 RVA: 0x0004CA3C File Offset: 0x0004AC3C
		public unsafe RectTransform DemoCirclesContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DemoCirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x00281604 File Offset: 0x0027F804
		// (set) Token: 0x06009D3E RID: 40254 RVA: 0x0004CA5B File Offset: 0x0004AC5B
		public unsafe RectTransform TutorialCirclesContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x06009D3F RID: 40255 RVA: 0x00281634 File Offset: 0x0027F834
		// (set) Token: 0x06009D40 RID: 40256 RVA: 0x0004CA7A File Offset: 0x0004AC7A
		public unsafe RectTransform ConnectionsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x06009D41 RID: 40257 RVA: 0x00281664 File Offset: 0x0027F864
		// (set) Token: 0x06009D42 RID: 40258 RVA: 0x0004CA99 File Offset: 0x0004AC99
		public unsafe RectTransform ContentRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ContentRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x06009D43 RID: 40259 RVA: 0x00281694 File Offset: 0x0027F894
		// (set) Token: 0x06009D44 RID: 40260 RVA: 0x0004CAB8 File Offset: 0x0004ACB8
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectionIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x06009D45 RID: 40261 RVA: 0x002816C4 File Offset: 0x0027F8C4
		// (set) Token: 0x06009D46 RID: 40262 RVA: 0x0004CAD7 File Offset: 0x0004ACD7
		public unsafe ContactsDetailPanel DetailPanel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DetailPanel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsDetailPanel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x06009D47 RID: 40263 RVA: 0x002816F4 File Offset: 0x0027F8F4
		// (set) Token: 0x06009D48 RID: 40264 RVA: 0x0004CAF6 File Offset: 0x0004ACF6
		public unsafe Il2CppReferenceArray<ContactsApp.RegionUI> RegionUIs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionUIs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContactsApp.RegionUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x06009D49 RID: 40265 RVA: 0x00281724 File Offset: 0x0027F924
		// (set) Token: 0x06009D4A RID: 40266 RVA: 0x0004CB15 File Offset: 0x0004AD15
		public unsafe RectTransform RegionSelectionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x06009D4B RID: 40267 RVA: 0x00281754 File Offset: 0x0027F954
		// (set) Token: 0x06009D4C RID: 40268 RVA: 0x0004CB34 File Offset: 0x0004AD34
		public unsafe RectTransform RegionSelectionIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x06009D4D RID: 40269 RVA: 0x00281784 File Offset: 0x0027F984
		// (set) Token: 0x06009D4E RID: 40270 RVA: 0x0004CB53 File Offset: 0x0004AD53
		public unsafe RectTransform LockedRegionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_LockedRegionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_LockedRegionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x06009D4F RID: 40271 RVA: 0x002817B4 File Offset: 0x0027F9B4
		// (set) Token: 0x06009D50 RID: 40272 RVA: 0x0004CB72 File Offset: 0x0004AD72
		public unsafe Text RegionRankRequirementLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionRankRequirementLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x06009D51 RID: 40273 RVA: 0x002817E4 File Offset: 0x0027F9E4
		// (set) Token: 0x06009D52 RID: 40274 RVA: 0x0004CB91 File Offset: 0x0004AD91
		public unsafe Image SelectedRegionIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegionIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x06009D53 RID: 40275 RVA: 0x00281814 File Offset: 0x0027FA14
		// (set) Token: 0x06009D54 RID: 40276 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		public unsafe GameObject ConnectionPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x06009D55 RID: 40277 RVA: 0x00281844 File Offset: 0x0027FA44
		// (set) Token: 0x06009D56 RID: 40278 RVA: 0x0004CBCF File Offset: 0x0004ADCF
		public unsafe List<RelationCircle> RelationCircles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RelationCircles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RelationCircle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RelationCircles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x06009D57 RID: 40279 RVA: 0x00281874 File Offset: 0x0027FA74
		// (set) Token: 0x06009D58 RID: 40280 RVA: 0x0004CBEE File Offset: 0x0004ADEE
		public unsafe Coroutine contentMoveRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_contentMoveRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_contentMoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x06009D59 RID: 40281 RVA: 0x002818A4 File Offset: 0x0027FAA4
		// (set) Token: 0x06009D5A RID: 40282 RVA: 0x0004CC0D File Offset: 0x0004AE0D
		public unsafe List<Il2CppSystem.Tuple<NPC, NPC>> connections
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_connections);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Tuple<NPC, NPC>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069BA RID: 27066
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedRegion;

		// Token: 0x040069BB RID: 27067
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionDict;

		// Token: 0x040069BC RID: 27068
		private static readonly System.IntPtr NativeFieldInfoPtr_CirclesContainer;

		// Token: 0x040069BD RID: 27069
		private static readonly System.IntPtr NativeFieldInfoPtr_DemoCirclesContainer;

		// Token: 0x040069BE RID: 27070
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialCirclesContainer;

		// Token: 0x040069BF RID: 27071
		private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionsContainer;

		// Token: 0x040069C0 RID: 27072
		private static readonly System.IntPtr NativeFieldInfoPtr_ContentRect;

		// Token: 0x040069C1 RID: 27073
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x040069C2 RID: 27074
		private static readonly System.IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x040069C3 RID: 27075
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionUIs;

		// Token: 0x040069C4 RID: 27076
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionSelectionContainer;

		// Token: 0x040069C5 RID: 27077
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionSelectionIndicator;

		// Token: 0x040069C6 RID: 27078
		private static readonly System.IntPtr NativeFieldInfoPtr_LockedRegionContainer;

		// Token: 0x040069C7 RID: 27079
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionRankRequirementLabel;

		// Token: 0x040069C8 RID: 27080
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedRegionIcon;

		// Token: 0x040069C9 RID: 27081
		private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionPrefab;

		// Token: 0x040069CA RID: 27082
		private static readonly System.IntPtr NativeFieldInfoPtr_RelationCircles;

		// Token: 0x040069CB RID: 27083
		private static readonly System.IntPtr NativeFieldInfoPtr_contentMoveRoutine;

		// Token: 0x040069CC RID: 27084
		private static readonly System.IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x040069CD RID: 27085
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040069CE RID: 27086
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040069CF RID: 27087
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0;

		// Token: 0x040069D0 RID: 27088
		private static readonly System.IntPtr NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0;

		// Token: 0x040069D1 RID: 27089
		private static readonly System.IntPtr NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0;

		// Token: 0x040069D2 RID: 27090
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_0;

		// Token: 0x040069D3 RID: 27091
		private static readonly System.IntPtr NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0;

		// Token: 0x040069D4 RID: 27092
		private static readonly System.IntPtr NativeMethodInfoPtr_StopContentMove_Private_Void_0;

		// Token: 0x040069D5 RID: 27093
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040069D6 RID: 27094
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BD4 RID: 3028
		[System.Serializable]
		public class RegionUI : Il2CppSystem.Object
		{
			// Token: 0x0600E0BF RID: 57535 RVA: 0x003555F0 File Offset: 0x003537F0
			// Note: this type is marked as 'beforefieldinit'.
			static RegionUI()
			{
				Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionUI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr);
				ContactsApp.RegionUI.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Region");
				ContactsApp.RegionUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Button");
				ContactsApp.RegionUI.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Container");
				ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "ConnectionsContainer");
				ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "<npcs>k__BackingField");
				ContactsApp.RegionUI.NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682740);
				ContactsApp.RegionUI.NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682741);
				ContactsApp.RegionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100682742);
			}

			// Token: 0x17004566 RID: 17766
			// (get) Token: 0x0600E0C0 RID: 57536 RVA: 0x003556BC File Offset: 0x003538BC
			// (set) Token: 0x0600E0C1 RID: 57537 RVA: 0x003556FC File Offset: 0x003538FC
			public unsafe List<NPC> npcs
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}
			}

			// Token: 0x0600E0C2 RID: 57538 RVA: 0x00355740 File Offset: 0x00353940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279229, XrefRangeEnd = 279237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RegionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0C3 RID: 57539 RVA: 0x0006D244 File Offset: 0x0006B444
			public RegionUI(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004561 RID: 17761
			// (get) Token: 0x0600E0C4 RID: 57540 RVA: 0x0035577C File Offset: 0x0035397C
			// (set) Token: 0x0600E0C5 RID: 57541 RVA: 0x0006D24D File Offset: 0x0006B44D
			public unsafe EMapRegion Region
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Region)) = value;
				}
			}

			// Token: 0x17004562 RID: 17762
			// (get) Token: 0x0600E0C6 RID: 57542 RVA: 0x003557A4 File Offset: 0x003539A4
			// (set) Token: 0x0600E0C7 RID: 57543 RVA: 0x0006D268 File Offset: 0x0006B468
			public unsafe Button Button
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Button);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004563 RID: 17763
			// (get) Token: 0x0600E0C8 RID: 57544 RVA: 0x003557D4 File Offset: 0x003539D4
			// (set) Token: 0x0600E0C9 RID: 57545 RVA: 0x0006D287 File Offset: 0x0006B487
			public unsafe RectTransform Container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004564 RID: 17764
			// (get) Token: 0x0600E0CA RID: 57546 RVA: 0x00355804 File Offset: 0x00353A04
			// (set) Token: 0x0600E0CB RID: 57547 RVA: 0x0006D2A6 File Offset: 0x0006B4A6
			public unsafe RectTransform ConnectionsContainer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004565 RID: 17765
			// (get) Token: 0x0600E0CC RID: 57548 RVA: 0x00355834 File Offset: 0x00353A34
			// (set) Token: 0x0600E0CD RID: 57549 RVA: 0x0006D2C5 File Offset: 0x0006B4C5
			public unsafe List<NPC> _npcs_k__BackingField
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096D1 RID: 38609
			private static readonly System.IntPtr NativeFieldInfoPtr_Region;

			// Token: 0x040096D2 RID: 38610
			private static readonly System.IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x040096D3 RID: 38611
			private static readonly System.IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x040096D4 RID: 38612
			private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionsContainer;

			// Token: 0x040096D5 RID: 38613
			private static readonly System.IntPtr NativeFieldInfoPtr__npcs_k__BackingField;

			// Token: 0x040096D6 RID: 38614
			private static readonly System.IntPtr NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0;

			// Token: 0x040096D7 RID: 38615
			private static readonly System.IntPtr NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0;

			// Token: 0x040096D8 RID: 38616
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BD5 RID: 3029
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0CE RID: 57550 RVA: 0x00355864 File Offset: 0x00353A64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, "cacheReg");
				ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, 100682743);
				ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr, 100682744);
			}

			// Token: 0x0600E0CF RID: 57551 RVA: 0x003558E0 File Offset: 0x00353AE0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0D0 RID: 57552 RVA: 0x0035591C File Offset: 0x00353B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279237, XrefRangeEnd = 279239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0D1 RID: 57553 RVA: 0x0006D2E4 File Offset: 0x0006B4E4
			public __c__DisplayClass20_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004567 RID: 17767
			// (get) Token: 0x0600E0D2 RID: 57554 RVA: 0x00355950 File Offset: 0x00353B50
			// (set) Token: 0x0600E0D3 RID: 57555 RVA: 0x0006D2ED File Offset: 0x0006B4ED
			public unsafe ContactsApp.RegionUI cacheReg
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.RegionUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr_cacheReg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004568 RID: 17768
			// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x00355980 File Offset: 0x00353B80
			// (set) Token: 0x0600E0D5 RID: 57557 RVA: 0x0006D30C File Offset: 0x0006B50C
			public unsafe ContactsApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096D9 RID: 38617
			private static readonly System.IntPtr NativeFieldInfoPtr_cacheReg;

			// Token: 0x040096DA RID: 38618
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096DB RID: 38619
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096DC RID: 38620
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000BD6 RID: 3030
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_1")]
		public sealed class __c__DisplayClass20_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E0D6 RID: 57558 RVA: 0x003559B0 File Offset: 0x00353BB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_1()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, "rel");
				ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, 100682745);
				ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr, 100682746);
			}

			// Token: 0x0600E0D7 RID: 57559 RVA: 0x00355A2C File Offset: 0x00353C2C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0D8 RID: 57560 RVA: 0x00355A68 File Offset: 0x00353C68
			[CallerCount(0)]
			public unsafe bool _Start_b__1(ContactsApp.RegionUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_1.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E0D9 RID: 57561 RVA: 0x0006D32B File Offset: 0x0006B52B
			public __c__DisplayClass20_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004569 RID: 17769
			// (get) Token: 0x0600E0DA RID: 57562 RVA: 0x00355AB8 File Offset: 0x00353CB8
			// (set) Token: 0x0600E0DB RID: 57563 RVA: 0x0006D334 File Offset: 0x0006B534
			public unsafe RelationCircle rel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr_rel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456A RID: 17770
			// (get) Token: 0x0600E0DC RID: 57564 RVA: 0x00355AE8 File Offset: 0x00353CE8
			// (set) Token: 0x0600E0DD RID: 57565 RVA: 0x0006D353 File Offset: 0x0006B553
			public unsafe ContactsApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096DD RID: 38621
			private static readonly System.IntPtr NativeFieldInfoPtr_rel;

			// Token: 0x040096DE RID: 38622
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096DF RID: 38623
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096E0 RID: 38624
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0;
		}

		// Token: 0x02000BD7 RID: 3031
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_2")]
		public sealed class __c__DisplayClass20_2 : Il2CppSystem.Object
		{
			// Token: 0x0600E0DE RID: 57566 RVA: 0x00355B18 File Offset: 0x00353D18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_2()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, "other");
				ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, "CS$<>8__locals1");
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682747);
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682748);
				ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr, 100682749);
			}

			// Token: 0x0600E0DF RID: 57567 RVA: 0x00355BA8 File Offset: 0x00353DA8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_2>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0E0 RID: 57568 RVA: 0x00355BE4 File Offset: 0x00353DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279239, XrefRangeEnd = 279245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__2(Il2CppSystem.Tuple<NPC, NPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E0E1 RID: 57569 RVA: 0x00355C34 File Offset: 0x00353E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279245, XrefRangeEnd = 279251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__3(Il2CppSystem.Tuple<NPC, NPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_2.NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E0E2 RID: 57570 RVA: 0x0006D372 File Offset: 0x0006B572
			public __c__DisplayClass20_2(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456B RID: 17771
			// (get) Token: 0x0600E0E3 RID: 57571 RVA: 0x00355C84 File Offset: 0x00353E84
			// (set) Token: 0x0600E0E4 RID: 57572 RVA: 0x0006D37B File Offset: 0x0006B57B
			public unsafe NPC other
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_other), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456C RID: 17772
			// (get) Token: 0x0600E0E5 RID: 57573 RVA: 0x00355CB4 File Offset: 0x00353EB4
			// (set) Token: 0x0600E0E6 RID: 57574 RVA: 0x0006D39A File Offset: 0x0006B59A
			public unsafe ContactsApp.__c__DisplayClass20_1 field_Public___c__DisplayClass20_1_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass20_1>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_2.NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096E1 RID: 38625
			private static readonly System.IntPtr NativeFieldInfoPtr_other;

			// Token: 0x040096E2 RID: 38626
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_1_0;

			// Token: 0x040096E3 RID: 38627
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096E4 RID: 38628
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0;

			// Token: 0x040096E5 RID: 38629
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0;
		}

		// Token: 0x02000BD8 RID: 3032
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_3")]
		public sealed class __c__DisplayClass20_3 : Il2CppSystem.Object
		{
			// Token: 0x0600E0E7 RID: 57575 RVA: 0x00355CE4 File Offset: 0x00353EE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_3()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "otherCirc");
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "cacheRel");
				ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, "CS$<>8__locals2");
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682750);
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682751);
				ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr, 100682752);
			}

			// Token: 0x0600E0E8 RID: 57576 RVA: 0x00355D88 File Offset: 0x00353F88
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_3>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0E9 RID: 57577 RVA: 0x00355DC4 File Offset: 0x00353FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279251, XrefRangeEnd = 279253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0EA RID: 57578 RVA: 0x00355DF8 File Offset: 0x00353FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279253, XrefRangeEnd = 279255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_3.NativeMethodInfoPtr__Start_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0EB RID: 57579 RVA: 0x0006D3B9 File Offset: 0x0006B5B9
			public __c__DisplayClass20_3(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456D RID: 17773
			// (get) Token: 0x0600E0EC RID: 57580 RVA: 0x00355E2C File Offset: 0x0035402C
			// (set) Token: 0x0600E0ED RID: 57581 RVA: 0x0006D3C2 File Offset: 0x0006B5C2
			public unsafe RelationCircle otherCirc
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_otherCirc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456E RID: 17774
			// (get) Token: 0x0600E0EE RID: 57582 RVA: 0x00355E5C File Offset: 0x0035405C
			// (set) Token: 0x0600E0EF RID: 57583 RVA: 0x0006D3E1 File Offset: 0x0006B5E1
			public unsafe RelationCircle cacheRel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_cacheRel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456F RID: 17775
			// (get) Token: 0x0600E0F0 RID: 57584 RVA: 0x00355E8C File Offset: 0x0035408C
			// (set) Token: 0x0600E0F1 RID: 57585 RVA: 0x0006D400 File Offset: 0x0006B600
			public unsafe ContactsApp.__c__DisplayClass20_2 field_Public___c__DisplayClass20_2_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass20_2>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_3.NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096E6 RID: 38630
			private static readonly System.IntPtr NativeFieldInfoPtr_otherCirc;

			// Token: 0x040096E7 RID: 38631
			private static readonly System.IntPtr NativeFieldInfoPtr_cacheRel;

			// Token: 0x040096E8 RID: 38632
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_2_0;

			// Token: 0x040096E9 RID: 38633
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096EA RID: 38634
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__4_Internal_Void_0;

			// Token: 0x040096EB RID: 38635
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__5_Internal_Void_0;
		}

		// Token: 0x02000BD9 RID: 3033
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass20_4")]
		public sealed class __c__DisplayClass20_4 : Il2CppSystem.Object
		{
			// Token: 0x0600E0F2 RID: 57586 RVA: 0x00355EBC File Offset: 0x003540BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_4()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass20_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr);
				ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, "circ");
				ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, 100682753);
				ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__Start_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr, 100682754);
			}

			// Token: 0x0600E0F3 RID: 57587 RVA: 0x00355F38 File Offset: 0x00354138
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass20_4>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0F4 RID: 57588 RVA: 0x00355F74 File Offset: 0x00354174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279255, XrefRangeEnd = 279259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass20_4.NativeMethodInfoPtr__Start_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0F5 RID: 57589 RVA: 0x0006D41F File Offset: 0x0006B61F
			public __c__DisplayClass20_4(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004570 RID: 17776
			// (get) Token: 0x0600E0F6 RID: 57590 RVA: 0x00355FA8 File Offset: 0x003541A8
			// (set) Token: 0x0600E0F7 RID: 57591 RVA: 0x0006D428 File Offset: 0x0006B628
			public unsafe RelationCircle circ
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr_circ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004571 RID: 17777
			// (get) Token: 0x0600E0F8 RID: 57592 RVA: 0x00355FD8 File Offset: 0x003541D8
			// (set) Token: 0x0600E0F9 RID: 57593 RVA: 0x0006D447 File Offset: 0x0006B647
			public unsafe ContactsApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass20_4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096EC RID: 38636
			private static readonly System.IntPtr NativeFieldInfoPtr_circ;

			// Token: 0x040096ED RID: 38637
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096EE RID: 38638
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096EF RID: 38639
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__6_Internal_Void_0;
		}

		// Token: 0x02000BDA RID: 3034
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0FA RID: 57594 RVA: 0x00356008 File Offset: 0x00354208
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, "npcID");
				ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, 100682755);
				ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr, 100682756);
			}

			// Token: 0x0600E0FB RID: 57595 RVA: 0x00356070 File Offset: 0x00354270
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass22_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0FC RID: 57596 RVA: 0x003560AC File Offset: 0x003542AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279259, XrefRangeEnd = 279263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRelationCircle_b__0(RelationCircle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E0FD RID: 57597 RVA: 0x0006D466 File Offset: 0x0006B666
			public __c__DisplayClass22_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004572 RID: 17778
			// (get) Token: 0x0600E0FE RID: 57598 RVA: 0x003560FC File Offset: 0x003542FC
			// (set) Token: 0x0600E0FF RID: 57599 RVA: 0x0006D46F File Offset: 0x0006B66F
			public unsafe string npcID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass22_0.NativeFieldInfoPtr_npcID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040096F0 RID: 38640
			private static readonly System.IntPtr NativeFieldInfoPtr_npcID;

			// Token: 0x040096F1 RID: 38641
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096F2 RID: 38642
			private static readonly System.IntPtr NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0;
		}

		// Token: 0x02000BDB RID: 3035
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E100 RID: 57600 RVA: 0x00356124 File Offset: 0x00354324
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "endPos");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "startScale");
				ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "endScale");
				ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, 100682757);
				ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, 100682758);
			}

			// Token: 0x0600E101 RID: 57601 RVA: 0x003561C8 File Offset: 0x003543C8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E102 RID: 57602 RVA: 0x00356204 File Offset: 0x00354404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279288, XrefRangeEnd = 279293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E103 RID: 57603 RVA: 0x0006D48E File Offset: 0x0006B68E
			public __c__DisplayClass26_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004573 RID: 17779
			// (get) Token: 0x0600E104 RID: 57604 RVA: 0x00356244 File Offset: 0x00354444
			// (set) Token: 0x0600E105 RID: 57605 RVA: 0x0006D497 File Offset: 0x0006B697
			public unsafe ContactsApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004574 RID: 17780
			// (get) Token: 0x0600E106 RID: 57606 RVA: 0x00356274 File Offset: 0x00354474
			// (set) Token: 0x0600E107 RID: 57607 RVA: 0x0006D4B6 File Offset: 0x0006B6B6
			public unsafe Vector2 endPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17004575 RID: 17781
			// (get) Token: 0x0600E108 RID: 57608 RVA: 0x0035629C File Offset: 0x0035449C
			// (set) Token: 0x0600E109 RID: 57609 RVA: 0x0006D4D1 File Offset: 0x0006B6D1
			public unsafe float startScale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17004576 RID: 17782
			// (get) Token: 0x0600E10A RID: 57610 RVA: 0x003562C4 File Offset: 0x003544C4
			// (set) Token: 0x0600E10B RID: 57611 RVA: 0x0006D4EC File Offset: 0x0006B6EC
			public unsafe float endScale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x040096F3 RID: 38643
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096F4 RID: 38644
			private static readonly System.IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x040096F5 RID: 38645
			private static readonly System.IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x040096F6 RID: 38646
			private static readonly System.IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x040096F7 RID: 38647
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096F8 RID: 38648
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CDC RID: 3292
			[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass26_0+<<ZoomToRect>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EC02 RID: 60418 RVA: 0x00375C8C File Offset: 0x00373E8C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique()
				{
					Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0>.NativeClassPtr, "<<ZoomToRect>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>1__state");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>2__current");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>4__this");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<startPos>5__2");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__3");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<i>5__4");
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682759);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682760);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682761);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682762);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682763);
					ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100682764);
				}

				// Token: 0x0600EC03 RID: 60419 RVA: 0x00375DA8 File Offset: 0x00373FA8
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC04 RID: 60420 RVA: 0x00375DF0 File Offset: 0x00373FF0
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC05 RID: 60421 RVA: 0x00375E24 File Offset: 0x00374024
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279263, XrefRangeEnd = 279283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004929 RID: 18729
				// (get) Token: 0x0600EC06 RID: 60422 RVA: 0x00375E60 File Offset: 0x00374060
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC07 RID: 60423 RVA: 0x00375EA0 File Offset: 0x003740A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279283, XrefRangeEnd = 279288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700492A RID: 18730
				// (get) Token: 0x0600EC08 RID: 60424 RVA: 0x00375ED4 File Offset: 0x003740D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC09 RID: 60425 RVA: 0x00072DDB File Offset: 0x00070FDB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004923 RID: 18723
				// (get) Token: 0x0600EC0A RID: 60426 RVA: 0x00375F14 File Offset: 0x00374114
				// (set) Token: 0x0600EC0B RID: 60427 RVA: 0x00072DE4 File Offset: 0x00070FE4
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004924 RID: 18724
				// (get) Token: 0x0600EC0C RID: 60428 RVA: 0x00375F3C File Offset: 0x0037413C
				// (set) Token: 0x0600EC0D RID: 60429 RVA: 0x00072DFF File Offset: 0x00070FFF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004925 RID: 18725
				// (get) Token: 0x0600EC0E RID: 60430 RVA: 0x00375F6C File Offset: 0x0037416C
				// (set) Token: 0x0600EC0F RID: 60431 RVA: 0x00072E1E File Offset: 0x0007101E
				public unsafe ContactsApp.__c__DisplayClass26_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004926 RID: 18726
				// (get) Token: 0x0600EC10 RID: 60432 RVA: 0x00375F9C File Offset: 0x0037419C
				// (set) Token: 0x0600EC11 RID: 60433 RVA: 0x00072E3D File Offset: 0x0007103D
				public unsafe Vector2 _startPos_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2)) = value;
					}
				}

				// Token: 0x17004927 RID: 18727
				// (get) Token: 0x0600EC12 RID: 60434 RVA: 0x00375FC4 File Offset: 0x003741C4
				// (set) Token: 0x0600EC13 RID: 60435 RVA: 0x00072E58 File Offset: 0x00071058
				public unsafe float _lerpTime_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
					}
				}

				// Token: 0x17004928 RID: 18728
				// (get) Token: 0x0600EC14 RID: 60436 RVA: 0x00375FEC File Offset: 0x003741EC
				// (set) Token: 0x0600EC15 RID: 60437 RVA: 0x00072E73 File Offset: 0x00071073
				public unsafe float _i_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009DCB RID: 40395
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009DCC RID: 40396
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009DCD RID: 40397
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009DCE RID: 40398
				private static readonly System.IntPtr NativeFieldInfoPtr__startPos_5__2;

				// Token: 0x04009DCF RID: 40399
				private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__3;

				// Token: 0x04009DD0 RID: 40400
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009DD1 RID: 40401
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009DD2 RID: 40402
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DD3 RID: 40403
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009DD4 RID: 40404
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009DD5 RID: 40405
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DD6 RID: 40406
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
