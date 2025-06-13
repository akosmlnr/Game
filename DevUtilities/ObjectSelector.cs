using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000481 RID: 1153
	public class ObjectSelector : Singleton<ObjectSelector>
	{
		// Token: 0x06006304 RID: 25348 RVA: 0x001C5CCC File Offset: 0x001C3ECC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelector()
		{
			Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ObjectSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr);
			ObjectSelector.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "detectionRange");
			ObjectSelector.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "detectionMask");
			ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "<isSelecting>k__BackingField");
			ObjectSelector.NativeFieldInfoPtr_allowedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "allowedTypes");
			ObjectSelector.NativeFieldInfoPtr_selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectedObjects");
			ObjectSelector.NativeFieldInfoPtr_selectedConstructables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectedConstructables");
			ObjectSelector.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "onClose");
			ObjectSelector.NativeFieldInfoPtr_selectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectionLimit");
			ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "exitOnSelectionLimit");
			ObjectSelector.NativeFieldInfoPtr_hoveredBuildable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "hoveredBuildable");
			ObjectSelector.NativeFieldInfoPtr_hoveredConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "hoveredConstructable");
			ObjectSelector.NativeFieldInfoPtr_outlinedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "outlinedObjects");
			ObjectSelector.NativeFieldInfoPtr_outlinedConstructables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "outlinedConstructables");
			ObjectSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675985);
			ObjectSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675986);
			ObjectSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675987);
			ObjectSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675988);
			ObjectSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675989);
			ObjectSelector.NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675990);
			ObjectSelector.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675991);
			ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675992);
			ObjectSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675993);
			ObjectSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675994);
			ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100675995);
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06006305 RID: 25349 RVA: 0x001C5EDC File Offset: 0x001C40DC
		// (set) Token: 0x06006306 RID: 25350 RVA: 0x001C5F18 File Offset: 0x001C4118
		public unsafe bool isSelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x001C5F58 File Offset: 0x001C4158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204756, XrefRangeEnd = 204769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x001C5F94 File Offset: 0x001C4194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204769, XrefRangeEnd = 204874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x001C5FD0 File Offset: 0x001C41D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204874, XrefRangeEnd = 204934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x001C600C File Offset: 0x001C420C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204934, XrefRangeEnd = 204951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItem GetHoveredBuildable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x001C604C File Offset: 0x001C424C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204951, XrefRangeEnd = 204968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x001C608C File Offset: 0x001C428C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204968, XrefRangeEnd = 204969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x001C60D0 File Offset: 0x001C42D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204969, XrefRangeEnd = 205009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSelecting(string selectionTitle, List<Il2CppSystem.Type> _typeRestriction, ref List<BuildableItem> initialSelection_Objects, ref List<Constructable> initalSelection_Constructables, int _selectionLimit, bool _exitOnSelectionLimit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_typeRestriction);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(initialSelection_Objects);
			ptr2 = &intPtr;
			ref System.IntPtr ptr3 = ref ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(initalSelection_Constructables);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _selectionLimit;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _exitOnSelectionLimit;
			System.IntPtr returnedException;
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr4 = intPtr;
			initialSelection_Objects = ((intPtr4 == 0) ? null : new List<BuildableItem>(intPtr4));
			System.IntPtr intPtr5 = intPtr2;
			initalSelection_Constructables = ((intPtr5 == 0) ? null : new List<Constructable>(intPtr5));
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x001C6194 File Offset: 0x001C4394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205036, RefRangeEnd = 205037, XrefRangeStart = 205009, XrefRangeEnd = 205036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSelecting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_StopSelecting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x001C61C8 File Offset: 0x001C43C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205037, XrefRangeEnd = 205064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x0002E8A5 File Offset: 0x0002CAA5
		public ObjectSelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06006311 RID: 25361 RVA: 0x001C6204 File Offset: 0x001C4404
		// (set) Token: 0x06006312 RID: 25362 RVA: 0x0002E8AE File Offset: 0x0002CAAE
		public unsafe float detectionRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06006313 RID: 25363 RVA: 0x001C622C File Offset: 0x001C442C
		// (set) Token: 0x06006314 RID: 25364 RVA: 0x0002E8C9 File Offset: 0x0002CAC9
		public unsafe LayerMask detectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06006315 RID: 25365 RVA: 0x001C6254 File Offset: 0x001C4454
		// (set) Token: 0x06006316 RID: 25366 RVA: 0x0002E8E4 File Offset: 0x0002CAE4
		public unsafe bool _isSelecting_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__isSelecting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06006317 RID: 25367 RVA: 0x001C627C File Offset: 0x001C447C
		// (set) Token: 0x06006318 RID: 25368 RVA: 0x0002E8FF File Offset: 0x0002CAFF
		public unsafe List<Il2CppSystem.Type> allowedTypes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_allowedTypes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_allowedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06006319 RID: 25369 RVA: 0x001C62AC File Offset: 0x001C44AC
		// (set) Token: 0x0600631A RID: 25370 RVA: 0x0002E91E File Offset: 0x0002CB1E
		public unsafe List<BuildableItem> selectedObjects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x0600631B RID: 25371 RVA: 0x001C62DC File Offset: 0x001C44DC
		// (set) Token: 0x0600631C RID: 25372 RVA: 0x0002E93D File Offset: 0x0002CB3D
		public unsafe List<Constructable> selectedConstructables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedConstructables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Constructable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedConstructables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x0600631D RID: 25373 RVA: 0x001C630C File Offset: 0x001C450C
		// (set) Token: 0x0600631E RID: 25374 RVA: 0x0002E95C File Offset: 0x0002CB5C
		public unsafe Il2CppSystem.Action onClose
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_onClose);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x0600631F RID: 25375 RVA: 0x001C633C File Offset: 0x001C453C
		// (set) Token: 0x06006320 RID: 25376 RVA: 0x0002E97B File Offset: 0x0002CB7B
		public unsafe int selectionLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionLimit)) = value;
			}
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06006321 RID: 25377 RVA: 0x001C6364 File Offset: 0x001C4564
		// (set) Token: 0x06006322 RID: 25378 RVA: 0x0002E996 File Offset: 0x0002CB96
		public unsafe bool exitOnSelectionLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_exitOnSelectionLimit)) = value;
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06006323 RID: 25379 RVA: 0x001C638C File Offset: 0x001C458C
		// (set) Token: 0x06006324 RID: 25380 RVA: 0x0002E9B1 File Offset: 0x0002CBB1
		public unsafe BuildableItem hoveredBuildable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredBuildable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredBuildable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06006325 RID: 25381 RVA: 0x001C63BC File Offset: 0x001C45BC
		// (set) Token: 0x06006326 RID: 25382 RVA: 0x0002E9D0 File Offset: 0x0002CBD0
		public unsafe Constructable hoveredConstructable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredConstructable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06006327 RID: 25383 RVA: 0x001C63EC File Offset: 0x001C45EC
		// (set) Token: 0x06006328 RID: 25384 RVA: 0x0002E9EF File Offset: 0x0002CBEF
		public unsafe List<BuildableItem> outlinedObjects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedObjects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06006329 RID: 25385 RVA: 0x001C641C File Offset: 0x001C461C
		// (set) Token: 0x0600632A RID: 25386 RVA: 0x0002EA0E File Offset: 0x0002CC0E
		public unsafe List<Constructable> outlinedConstructables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedConstructables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Constructable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_outlinedConstructables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004397 RID: 17303
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x04004398 RID: 17304
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x04004399 RID: 17305
		private static readonly System.IntPtr NativeFieldInfoPtr__isSelecting_k__BackingField;

		// Token: 0x0400439A RID: 17306
		private static readonly System.IntPtr NativeFieldInfoPtr_allowedTypes;

		// Token: 0x0400439B RID: 17307
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedObjects;

		// Token: 0x0400439C RID: 17308
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedConstructables;

		// Token: 0x0400439D RID: 17309
		private static readonly System.IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x0400439E RID: 17310
		private static readonly System.IntPtr NativeFieldInfoPtr_selectionLimit;

		// Token: 0x0400439F RID: 17311
		private static readonly System.IntPtr NativeFieldInfoPtr_exitOnSelectionLimit;

		// Token: 0x040043A0 RID: 17312
		private static readonly System.IntPtr NativeFieldInfoPtr_hoveredBuildable;

		// Token: 0x040043A1 RID: 17313
		private static readonly System.IntPtr NativeFieldInfoPtr_hoveredConstructable;

		// Token: 0x040043A2 RID: 17314
		private static readonly System.IntPtr NativeFieldInfoPtr_outlinedObjects;

		// Token: 0x040043A3 RID: 17315
		private static readonly System.IntPtr NativeFieldInfoPtr_outlinedConstructables;

		// Token: 0x040043A4 RID: 17316
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isSelecting_Public_get_Boolean_0;

		// Token: 0x040043A5 RID: 17317
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isSelecting_Protected_set_Void_Boolean_0;

		// Token: 0x040043A6 RID: 17318
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040043A7 RID: 17319
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040043A8 RID: 17320
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040043A9 RID: 17321
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredBuildable_Private_BuildableItem_0;

		// Token: 0x040043AA RID: 17322
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Private_Constructable_0;

		// Token: 0x040043AB RID: 17323
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040043AC RID: 17324
		private static readonly System.IntPtr NativeMethodInfoPtr_StartSelecting_Public_Void_String_List_1_Type_byref_List_1_BuildableItem_byref_List_1_Constructable_Int32_Boolean_0;

		// Token: 0x040043AD RID: 17325
		private static readonly System.IntPtr NativeMethodInfoPtr_StopSelecting_Public_Void_0;

		// Token: 0x040043AE RID: 17326
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
