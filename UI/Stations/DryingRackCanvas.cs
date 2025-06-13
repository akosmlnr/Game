using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Stations.Drying_rack;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x020006A3 RID: 1699
	public class DryingRackCanvas : Singleton<DryingRackCanvas>
	{
		// Token: 0x060096F0 RID: 38640 RVA: 0x0026E67C File Offset: 0x0026C87C
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackCanvas()
		{
			Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "DryingRackCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr);
			DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<Rack>k__BackingField");
			DryingRackCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "Canvas");
			DryingRackCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "Container");
			DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InputSlotUI");
			DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "OutputSlotUI");
			DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InstructionLabel");
			DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "CapacityLabel");
			DryingRackCanvas.NativeFieldInfoPtr_InsertButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "InsertButton");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorContainer");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorAlignments");
			DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "IndicatorPrefab");
			DryingRackCanvas.NativeFieldInfoPtr_operationUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "operationUIs");
			DryingRackCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682078);
			DryingRackCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682079);
			DryingRackCanvas.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682080);
			DryingRackCanvas.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682081);
			DryingRackCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682082);
			DryingRackCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682083);
			DryingRackCanvas.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682084);
			DryingRackCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682085);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682086);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682087);
			DryingRackCanvas.NativeMethodInfoPtr_UpdateQuantities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682088);
			DryingRackCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682089);
			DryingRackCanvas.NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682090);
			DryingRackCanvas.NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682091);
			DryingRackCanvas.NativeMethodInfoPtr_Insert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682092);
			DryingRackCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, 100682093);
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x060096F1 RID: 38641 RVA: 0x0026E8F0 File Offset: 0x0026CAF0
		// (set) Token: 0x060096F2 RID: 38642 RVA: 0x0026E92C File Offset: 0x0026CB2C
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x060096F3 RID: 38643 RVA: 0x0026E96C File Offset: 0x0026CB6C
		// (set) Token: 0x060096F4 RID: 38644 RVA: 0x0026E9AC File Offset: 0x0026CBAC
		public unsafe DryingRack Rack
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x0026E9F0 File Offset: 0x0026CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271185, XrefRangeEnd = 271188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x0026EA2C File Offset: 0x0026CC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271188, XrefRangeEnd = 271210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x0026EA68 File Offset: 0x0026CC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271210, XrefRangeEnd = 271211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x0026EA9C File Offset: 0x0026CC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271211, XrefRangeEnd = 271212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096F9 RID: 38649 RVA: 0x0026EAD8 File Offset: 0x0026CCD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271222, RefRangeEnd = 271224, XrefRangeStart = 271212, XrefRangeEnd = 271222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x0026EB0C File Offset: 0x0026CD0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 271253, RefRangeEnd = 271257, XrefRangeStart = 271224, XrefRangeEnd = 271253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDryingOperations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096FB RID: 38651 RVA: 0x0026EB40 File Offset: 0x0026CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271257, XrefRangeEnd = 271275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_UpdateQuantities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x0026EB74 File Offset: 0x0026CD74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271459, RefRangeEnd = 271462, XrefRangeStart = 271275, XrefRangeEnd = 271459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(DryingRack rack, bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096FD RID: 38653 RVA: 0x0026EBC4 File Offset: 0x0026CDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271462, XrefRangeEnd = 271481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOperationUI(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096FE RID: 38654 RVA: 0x0026EC08 File Offset: 0x0026CE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271481, XrefRangeEnd = 271506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyOperationUI(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x0026EC4C File Offset: 0x0026CE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271506, XrefRangeEnd = 271508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr_Insert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009700 RID: 38656 RVA: 0x0026EC80 File Offset: 0x0026CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271508, XrefRangeEnd = 271518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009701 RID: 38657 RVA: 0x00049072 File Offset: 0x00047272
		public DryingRackCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x06009702 RID: 38658 RVA: 0x0026ECBC File Offset: 0x0026CEBC
		// (set) Token: 0x06009703 RID: 38659 RVA: 0x0004907B File Offset: 0x0004727B
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E21 RID: 11809
		// (get) Token: 0x06009704 RID: 38660 RVA: 0x0026ECE4 File Offset: 0x0026CEE4
		// (set) Token: 0x06009705 RID: 38661 RVA: 0x00049096 File Offset: 0x00047296
		public unsafe DryingRack _Rack_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr__Rack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x06009706 RID: 38662 RVA: 0x0026ED14 File Offset: 0x0026CF14
		// (set) Token: 0x06009707 RID: 38663 RVA: 0x000490B5 File Offset: 0x000472B5
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x06009708 RID: 38664 RVA: 0x0026ED44 File Offset: 0x0026CF44
		// (set) Token: 0x06009709 RID: 38665 RVA: 0x000490D4 File Offset: 0x000472D4
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0600970A RID: 38666 RVA: 0x0026ED74 File Offset: 0x0026CF74
		// (set) Token: 0x0600970B RID: 38667 RVA: 0x000490F3 File Offset: 0x000472F3
		public unsafe ItemSlotUI InputSlotUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0600970C RID: 38668 RVA: 0x0026EDA4 File Offset: 0x0026CFA4
		// (set) Token: 0x0600970D RID: 38669 RVA: 0x00049112 File Offset: 0x00047312
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0600970E RID: 38670 RVA: 0x0026EDD4 File Offset: 0x0026CFD4
		// (set) Token: 0x0600970F RID: 38671 RVA: 0x00049131 File Offset: 0x00047331
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x06009710 RID: 38672 RVA: 0x0026EE04 File Offset: 0x0026D004
		// (set) Token: 0x06009711 RID: 38673 RVA: 0x00049150 File Offset: 0x00047350
		public unsafe TextMeshProUGUI CapacityLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_CapacityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x06009712 RID: 38674 RVA: 0x0026EE34 File Offset: 0x0026D034
		// (set) Token: 0x06009713 RID: 38675 RVA: 0x0004916F File Offset: 0x0004736F
		public unsafe Button InsertButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InsertButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_InsertButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x06009714 RID: 38676 RVA: 0x0026EE64 File Offset: 0x0026D064
		// (set) Token: 0x06009715 RID: 38677 RVA: 0x0004918E File Offset: 0x0004738E
		public unsafe RectTransform IndicatorContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x06009716 RID: 38678 RVA: 0x0026EE94 File Offset: 0x0026D094
		// (set) Token: 0x06009717 RID: 38679 RVA: 0x000491AD File Offset: 0x000473AD
		public unsafe Il2CppReferenceArray<RectTransform> IndicatorAlignments
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x06009718 RID: 38680 RVA: 0x0026EEC4 File Offset: 0x0026D0C4
		// (set) Token: 0x06009719 RID: 38681 RVA: 0x000491CC File Offset: 0x000473CC
		public unsafe DryingOperationUI IndicatorPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperationUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_IndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0600971A RID: 38682 RVA: 0x0026EEF4 File Offset: 0x0026D0F4
		// (set) Token: 0x0600971B RID: 38683 RVA: 0x000491EB File Offset: 0x000473EB
		public unsafe List<DryingOperationUI> operationUIs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_operationUIs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingOperationUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.NativeFieldInfoPtr_operationUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065D8 RID: 26072
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040065D9 RID: 26073
		private static readonly System.IntPtr NativeFieldInfoPtr__Rack_k__BackingField;

		// Token: 0x040065DA RID: 26074
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040065DB RID: 26075
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040065DC RID: 26076
		private static readonly System.IntPtr NativeFieldInfoPtr_InputSlotUI;

		// Token: 0x040065DD RID: 26077
		private static readonly System.IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x040065DE RID: 26078
		private static readonly System.IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x040065DF RID: 26079
		private static readonly System.IntPtr NativeFieldInfoPtr_CapacityLabel;

		// Token: 0x040065E0 RID: 26080
		private static readonly System.IntPtr NativeFieldInfoPtr_InsertButton;

		// Token: 0x040065E1 RID: 26081
		private static readonly System.IntPtr NativeFieldInfoPtr_IndicatorContainer;

		// Token: 0x040065E2 RID: 26082
		private static readonly System.IntPtr NativeFieldInfoPtr_IndicatorAlignments;

		// Token: 0x040065E3 RID: 26083
		private static readonly System.IntPtr NativeFieldInfoPtr_IndicatorPrefab;

		// Token: 0x040065E4 RID: 26084
		private static readonly System.IntPtr NativeFieldInfoPtr_operationUIs;

		// Token: 0x040065E5 RID: 26085
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040065E6 RID: 26086
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040065E7 RID: 26087
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0;

		// Token: 0x040065E8 RID: 26088
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0;

		// Token: 0x040065E9 RID: 26089
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040065EA RID: 26090
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040065EB RID: 26091
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040065EC RID: 26092
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040065ED RID: 26093
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x040065EE RID: 26094
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0;

		// Token: 0x040065EF RID: 26095
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateQuantities_Private_Void_0;

		// Token: 0x040065F0 RID: 26096
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_DryingRack_Boolean_0;

		// Token: 0x040065F1 RID: 26097
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0;

		// Token: 0x040065F2 RID: 26098
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0;

		// Token: 0x040065F3 RID: 26099
		private static readonly System.IntPtr NativeMethodInfoPtr_Insert_Public_Void_0;

		// Token: 0x040065F4 RID: 26100
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAC RID: 2988
		[ObfuscatedName("ScheduleOne.UI.Stations.DryingRackCanvas+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF62 RID: 57186 RVA: 0x00351950 File Offset: 0x0034FB50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DryingRackCanvas>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr);
				DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, "operation");
				DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, 100682094);
				DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr, 100682095);
			}

			// Token: 0x0600DF63 RID: 57187 RVA: 0x003519B8 File Offset: 0x0034FBB8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackCanvas.__c__DisplayClass28_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF64 RID: 57188 RVA: 0x003519F4 File Offset: 0x0034FBF4
			[CallerCount(0)]
			public unsafe bool _DestroyOperationUI_b__0(DryingOperationUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DryingRackCanvas.__c__DisplayClass28_0.NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF65 RID: 57189 RVA: 0x0006C73F File Offset: 0x0006A93F
			public __c__DisplayClass28_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044FD RID: 17661
			// (get) Token: 0x0600DF66 RID: 57190 RVA: 0x00351A44 File Offset: 0x0034FC44
			// (set) Token: 0x0600DF67 RID: 57191 RVA: 0x0006C748 File Offset: 0x0006A948
			public unsafe DryingOperation operation
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackCanvas.__c__DisplayClass28_0.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400960E RID: 38414
			private static readonly System.IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x0400960F RID: 38415
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009610 RID: 38416
			private static readonly System.IntPtr NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0;
		}
	}
}
