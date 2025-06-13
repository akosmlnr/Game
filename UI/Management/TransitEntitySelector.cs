using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006FA RID: 1786
	public class TransitEntitySelector : MonoBehaviour
	{
		// Token: 0x06009FD1 RID: 40913 RVA: 0x002890D8 File Offset: 0x002872D8
		// Note: this type is marked as 'beforefieldinit'.
		static TransitEntitySelector()
		{
			Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "TransitEntitySelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr);
			TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "SELECTION_RANGE");
			TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			TransitEntitySelector.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "DetectionMask");
			TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "HoverOutlineColor");
			TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "SelectOutlineColor");
			TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "maxSelectedObjects");
			TransitEntitySelector.NativeFieldInfoPtr_selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectedObjects");
			TransitEntitySelector.NativeFieldInfoPtr_typeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "typeRequirements");
			TransitEntitySelector.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "objectFilter");
			TransitEntitySelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "callback");
			TransitEntitySelector.NativeFieldInfoPtr_hoveredObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "hoveredObj");
			TransitEntitySelector.NativeFieldInfoPtr_highlightedObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "highlightedObj");
			TransitEntitySelector.NativeFieldInfoPtr_selectionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectionTitle");
			TransitEntitySelector.NativeFieldInfoPtr_changesMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "changesMade");
			TransitEntitySelector.NativeFieldInfoPtr_transitSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "transitSources");
			TransitEntitySelector.NativeFieldInfoPtr_transitLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "transitLines");
			TransitEntitySelector.NativeFieldInfoPtr_selectDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectDestination");
			TransitEntitySelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683005);
			TransitEntitySelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683006);
			TransitEntitySelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683007);
			TransitEntitySelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683008);
			TransitEntitySelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683009);
			TransitEntitySelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683010);
			TransitEntitySelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683011);
			TransitEntitySelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683012);
			TransitEntitySelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683013);
			TransitEntitySelector.NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683014);
			TransitEntitySelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683015);
			TransitEntitySelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683016);
			TransitEntitySelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683017);
			TransitEntitySelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683018);
			TransitEntitySelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683019);
			TransitEntitySelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100683020);
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x06009FD2 RID: 40914 RVA: 0x0028939C File Offset: 0x0028759C
		// (set) Token: 0x06009FD3 RID: 40915 RVA: 0x002893D8 File Offset: 0x002875D8
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x00289418 File Offset: 0x00287618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283526, XrefRangeEnd = 283548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x0028944C File Offset: 0x0028764C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283548, XrefRangeEnd = 283629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<ITransitEntity> _selectedObjects, List<Il2CppSystem.Type> _typeRequirements, TransitEntitySelector.ObjectFilter _objectFilter, Il2CppSystem.Action<List<ITransitEntity>> _callback, List<Transform> transitLineSources = null, bool selectingDestination = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_selectionTitle);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(instruction);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _maxSelectedObjects;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedObjects);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_typeRequirements);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_objectFilter);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transitLineSources);
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref selectingDestination;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitEntitySelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x00289528 File Offset: 0x00287728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283666, RefRangeEnd = 283668, XrefRangeStart = 283629, XrefRangeEnd = 283666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransitLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x0028955C File Offset: 0x0028775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283668, XrefRangeEnd = 283729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(bool returnToClipboard, bool pushChanges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref returnToClipboard;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pushChanges;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitEntitySelector.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x002895B4 File Offset: 0x002877B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283729, XrefRangeEnd = 283782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x002895E8 File Offset: 0x002877E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283782, XrefRangeEnd = 283783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x0028961C File Offset: 0x0028781C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283807, RefRangeEnd = 283809, XrefRangeStart = 283783, XrefRangeEnd = 283807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x00289650 File Offset: 0x00287850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283809, XrefRangeEnd = 283815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITransitEntity GetHoveredObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x00289690 File Offset: 0x00287890
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283832, RefRangeEnd = 283835, XrefRangeStart = 283815, XrefRangeEnd = 283832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectTypeValid(ITransitEntity obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x002896F8 File Offset: 0x002878F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283857, RefRangeEnd = 283858, XrefRangeStart = 283835, XrefRangeEnd = 283857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectClicked(ITransitEntity obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x0028973C File Offset: 0x0028793C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283862, RefRangeEnd = 283863, XrefRangeStart = 283858, XrefRangeEnd = 283862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectionOutline(ITransitEntity obj, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref on;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x0028978C File Offset: 0x0028798C
		[CallerCount(0)]
		public unsafe void ClipboardClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x002897C0 File Offset: 0x002879C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FE1 RID: 40929 RVA: 0x00289804 File Offset: 0x00287A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283863, XrefRangeEnd = 283896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitEntitySelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009FE2 RID: 40930 RVA: 0x0004E2E7 File Offset: 0x0004C4E7
		public TransitEntitySelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x06009FE3 RID: 40931 RVA: 0x00289840 File Offset: 0x00287A40
		// (set) Token: 0x06009FE4 RID: 40932 RVA: 0x0004E2F0 File Offset: 0x0004C4F0
		public unsafe static float SELECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x06009FE5 RID: 40933 RVA: 0x0028985C File Offset: 0x00287A5C
		// (set) Token: 0x06009FE6 RID: 40934 RVA: 0x0004E2FE File Offset: 0x0004C4FE
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x06009FE7 RID: 40935 RVA: 0x00289884 File Offset: 0x00287A84
		// (set) Token: 0x06009FE8 RID: 40936 RVA: 0x0004E319 File Offset: 0x0004C519
		public unsafe LayerMask DetectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x06009FE9 RID: 40937 RVA: 0x002898AC File Offset: 0x00287AAC
		// (set) Token: 0x06009FEA RID: 40938 RVA: 0x0004E334 File Offset: 0x0004C534
		public unsafe Color HoverOutlineColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor)) = value;
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x06009FEB RID: 40939 RVA: 0x002898D4 File Offset: 0x00287AD4
		// (set) Token: 0x06009FEC RID: 40940 RVA: 0x0004E34F File Offset: 0x0004C54F
		public unsafe Color SelectOutlineColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor)) = value;
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x06009FED RID: 40941 RVA: 0x002898FC File Offset: 0x00287AFC
		// (set) Token: 0x06009FEE RID: 40942 RVA: 0x0004E36A File Offset: 0x0004C56A
		public unsafe int maxSelectedObjects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects)) = value;
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x06009FEF RID: 40943 RVA: 0x00289924 File Offset: 0x00287B24
		// (set) Token: 0x06009FF0 RID: 40944 RVA: 0x0004E385 File Offset: 0x0004C585
		public unsafe List<ITransitEntity> selectedObjects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectedObjects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x06009FF1 RID: 40945 RVA: 0x00289954 File Offset: 0x00287B54
		// (set) Token: 0x06009FF2 RID: 40946 RVA: 0x0004E3A4 File Offset: 0x0004C5A4
		public unsafe List<Il2CppSystem.Type> typeRequirements
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_typeRequirements);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_typeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x06009FF3 RID: 40947 RVA: 0x00289984 File Offset: 0x00287B84
		// (set) Token: 0x06009FF4 RID: 40948 RVA: 0x0004E3C3 File Offset: 0x0004C5C3
		public unsafe TransitEntitySelector.ObjectFilter objectFilter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_objectFilter);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitEntitySelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x06009FF5 RID: 40949 RVA: 0x002899B4 File Offset: 0x00287BB4
		// (set) Token: 0x06009FF6 RID: 40950 RVA: 0x0004E3E2 File Offset: 0x0004C5E2
		public unsafe Il2CppSystem.Action<List<ITransitEntity>> callback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_callback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<List<ITransitEntity>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x06009FF7 RID: 40951 RVA: 0x002899E4 File Offset: 0x00287BE4
		// (set) Token: 0x06009FF8 RID: 40952 RVA: 0x0004E401 File Offset: 0x0004C601
		public unsafe ITransitEntity hoveredObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_hoveredObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_hoveredObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x06009FF9 RID: 40953 RVA: 0x00289A14 File Offset: 0x00287C14
		// (set) Token: 0x06009FFA RID: 40954 RVA: 0x0004E420 File Offset: 0x0004C620
		public unsafe ITransitEntity highlightedObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_highlightedObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_highlightedObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x06009FFB RID: 40955 RVA: 0x00289A44 File Offset: 0x00287C44
		// (set) Token: 0x06009FFC RID: 40956 RVA: 0x0004E43F File Offset: 0x0004C63F
		public unsafe string selectionTitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectionTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectionTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x06009FFD RID: 40957 RVA: 0x00289A6C File Offset: 0x00287C6C
		// (set) Token: 0x06009FFE RID: 40958 RVA: 0x0004E45E File Offset: 0x0004C65E
		public unsafe bool changesMade
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_changesMade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_changesMade)) = value;
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x06009FFF RID: 40959 RVA: 0x00289A94 File Offset: 0x00287C94
		// (set) Token: 0x0600A000 RID: 40960 RVA: 0x0004E479 File Offset: 0x0004C679
		public unsafe List<Transform> transitSources
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitSources);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0600A001 RID: 40961 RVA: 0x00289AC4 File Offset: 0x00287CC4
		// (set) Token: 0x0600A002 RID: 40962 RVA: 0x0004E498 File Offset: 0x0004C698
		public unsafe List<TransitLineVisuals> transitLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TransitLineVisuals>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0600A003 RID: 40963 RVA: 0x00289AF4 File Offset: 0x00287CF4
		// (set) Token: 0x0600A004 RID: 40964 RVA: 0x0004E4B7 File Offset: 0x0004C6B7
		public unsafe bool selectDestination
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectDestination)) = value;
			}
		}

		// Token: 0x04006B57 RID: 27479
		private static readonly System.IntPtr NativeFieldInfoPtr_SELECTION_RANGE;

		// Token: 0x04006B58 RID: 27480
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006B59 RID: 27481
		private static readonly System.IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04006B5A RID: 27482
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverOutlineColor;

		// Token: 0x04006B5B RID: 27483
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectOutlineColor;

		// Token: 0x04006B5C RID: 27484
		private static readonly System.IntPtr NativeFieldInfoPtr_maxSelectedObjects;

		// Token: 0x04006B5D RID: 27485
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedObjects;

		// Token: 0x04006B5E RID: 27486
		private static readonly System.IntPtr NativeFieldInfoPtr_typeRequirements;

		// Token: 0x04006B5F RID: 27487
		private static readonly System.IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x04006B60 RID: 27488
		private static readonly System.IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04006B61 RID: 27489
		private static readonly System.IntPtr NativeFieldInfoPtr_hoveredObj;

		// Token: 0x04006B62 RID: 27490
		private static readonly System.IntPtr NativeFieldInfoPtr_highlightedObj;

		// Token: 0x04006B63 RID: 27491
		private static readonly System.IntPtr NativeFieldInfoPtr_selectionTitle;

		// Token: 0x04006B64 RID: 27492
		private static readonly System.IntPtr NativeFieldInfoPtr_changesMade;

		// Token: 0x04006B65 RID: 27493
		private static readonly System.IntPtr NativeFieldInfoPtr_transitSources;

		// Token: 0x04006B66 RID: 27494
		private static readonly System.IntPtr NativeFieldInfoPtr_transitLines;

		// Token: 0x04006B67 RID: 27495
		private static readonly System.IntPtr NativeFieldInfoPtr_selectDestination;

		// Token: 0x04006B68 RID: 27496
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006B69 RID: 27497
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006B6A RID: 27498
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006B6B RID: 27499
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0;

		// Token: 0x04006B6C RID: 27500
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0;

		// Token: 0x04006B6D RID: 27501
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x04006B6E RID: 27502
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006B6F RID: 27503
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006B70 RID: 27504
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstructions_Private_Void_0;

		// Token: 0x04006B71 RID: 27505
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0;

		// Token: 0x04006B72 RID: 27506
		private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0;

		// Token: 0x04006B73 RID: 27507
		private static readonly System.IntPtr NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0;

		// Token: 0x04006B74 RID: 27508
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0;

		// Token: 0x04006B75 RID: 27509
		private static readonly System.IntPtr NativeMethodInfoPtr_ClipboardClosed_Private_Void_0;

		// Token: 0x04006B76 RID: 27510
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006B77 RID: 27511
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE9 RID: 3049
		public sealed class ObjectFilter : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600E175 RID: 57717 RVA: 0x003575CC File Offset: 0x003557CC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectFilter()
			{
				Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "ObjectFilter");
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100683021);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100683022);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100683023);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100683024);
			}

			// Token: 0x0600E176 RID: 57718 RVA: 0x00357640 File Offset: 0x00355840
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 67607, RefRangeEnd = 67650, XrefRangeStart = 67607, XrefRangeEnd = 67650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectFilter(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E177 RID: 57719 RVA: 0x0035769C File Offset: 0x0035589C
			[CallerCount(0)]
			public unsafe bool Invoke(ITransitEntity obj, out string reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
				System.IntPtr il2CppString = 0;
				ptr2 = &il2CppString;
				System.IntPtr returnedException;
				System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				reason = IL2CPP.Il2CppStringToManaged(il2CppString);
				return *IL2CPP.il2cpp_object_unbox(obj2);
			}

			// Token: 0x0600E178 RID: 57720 RVA: 0x00357704 File Offset: 0x00355904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(ITransitEntity obj, out string reason, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
				System.IntPtr il2CppString = 0;
				ptr2 = &il2CppString;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				reason = IL2CPP.Il2CppStringToManaged(il2CppString);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600E179 RID: 57721 RVA: 0x00357794 File Offset: 0x00355994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out string reason, Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				ref System.IntPtr ptr2 = ref *ptr;
				System.IntPtr il2CppString = 0;
				ptr2 = &il2CppString;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				reason = IL2CPP.Il2CppStringToManaged(il2CppString);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E17A RID: 57722 RVA: 0x0006D7F9 File Offset: 0x0006B9F9
			public ObjectFilter(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400972F RID: 38703
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009730 RID: 38704
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0;

			// Token: 0x04009731 RID: 38705
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0;

			// Token: 0x04009732 RID: 38706
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}
