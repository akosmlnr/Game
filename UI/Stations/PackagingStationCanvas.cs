using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x020006A6 RID: 1702
	public class PackagingStationCanvas : Singleton<PackagingStationCanvas>
	{
		// Token: 0x0600978F RID: 38799 RVA: 0x002705A8 File Offset: 0x0026E7A8
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationCanvas()
		{
			Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "PackagingStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr);
			PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "<PackagingStation>k__BackingField");
			PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ShowHintOnOpen");
			PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ShowShiftClickHint");
			PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "CurrentMode");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionWarningColor");
			PackagingStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "Canvas");
			PackagingStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "Container");
			PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "PackagingSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ProductSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "OutputSlotUI");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionLabel");
			PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "InstructionShadow");
			PackagingStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "BeginButton");
			PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ModeAnimation");
			PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, "ButtonLabel");
			PackagingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682135);
			PackagingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682136);
			PackagingStationCanvas.NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682137);
			PackagingStationCanvas.NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682138);
			PackagingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682139);
			PackagingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682140);
			PackagingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682141);
			PackagingStationCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682142);
			PackagingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682143);
			PackagingStationCanvas.NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682144);
			PackagingStationCanvas.NativeMethodInfoPtr_ToggleMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682145);
			PackagingStationCanvas.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682146);
			PackagingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr, 100682147);
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x06009790 RID: 38800 RVA: 0x0027081C File Offset: 0x0026EA1C
		// (set) Token: 0x06009791 RID: 38801 RVA: 0x00270858 File Offset: 0x0026EA58
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x06009792 RID: 38802 RVA: 0x00270898 File Offset: 0x0026EA98
		// (set) Token: 0x06009793 RID: 38803 RVA: 0x002708D8 File Offset: 0x0026EAD8
		public unsafe PackagingStation PackagingStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x0027091C File Offset: 0x0026EB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272340, XrefRangeEnd = 272351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x00270958 File Offset: 0x0026EB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272351, XrefRangeEnd = 272355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x00270994 File Offset: 0x0026EB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272355, XrefRangeEnd = 272390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x002709D0 File Offset: 0x0026EBD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 272481, RefRangeEnd = 272485, XrefRangeStart = 272390, XrefRangeEnd = 272481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(PackagingStation station, bool open, bool removeUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeUI;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009798 RID: 38808 RVA: 0x00270A30 File Offset: 0x0026EC30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272502, RefRangeEnd = 272503, XrefRangeStart = 272485, XrefRangeEnd = 272502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009799 RID: 38809 RVA: 0x00270A64 File Offset: 0x0026EC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272503, XrefRangeEnd = 272526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSlotPositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600979A RID: 38810 RVA: 0x00270A98 File Offset: 0x0026EC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272526, XrefRangeEnd = 272527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_ToggleMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600979B RID: 38811 RVA: 0x00270ACC File Offset: 0x0026ECCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272572, RefRangeEnd = 272573, XrefRangeStart = 272527, XrefRangeEnd = 272572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(PackagingStation.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600979C RID: 38812 RVA: 0x00270B0C File Offset: 0x0026ED0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272573, XrefRangeEnd = 272576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationCanvas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600979D RID: 38813 RVA: 0x00049670 File Offset: 0x00047870
		public PackagingStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0600979E RID: 38814 RVA: 0x00270B48 File Offset: 0x0026ED48
		// (set) Token: 0x0600979F RID: 38815 RVA: 0x00049679 File Offset: 0x00047879
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x060097A0 RID: 38816 RVA: 0x00270B70 File Offset: 0x0026ED70
		// (set) Token: 0x060097A1 RID: 38817 RVA: 0x00049694 File Offset: 0x00047894
		public unsafe PackagingStation _PackagingStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr__PackagingStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x060097A2 RID: 38818 RVA: 0x00270BA0 File Offset: 0x0026EDA0
		// (set) Token: 0x060097A3 RID: 38819 RVA: 0x000496B3 File Offset: 0x000478B3
		public unsafe bool ShowHintOnOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowHintOnOpen)) = value;
			}
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x060097A4 RID: 38820 RVA: 0x00270BC8 File Offset: 0x0026EDC8
		// (set) Token: 0x060097A5 RID: 38821 RVA: 0x000496CE File Offset: 0x000478CE
		public unsafe bool ShowShiftClickHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ShowShiftClickHint)) = value;
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x060097A6 RID: 38822 RVA: 0x00270BF0 File Offset: 0x0026EDF0
		// (set) Token: 0x060097A7 RID: 38823 RVA: 0x000496E9 File Offset: 0x000478E9
		public unsafe PackagingStation.EMode CurrentMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_CurrentMode)) = value;
			}
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x060097A8 RID: 38824 RVA: 0x00270C18 File Offset: 0x0026EE18
		// (set) Token: 0x060097A9 RID: 38825 RVA: 0x00049704 File Offset: 0x00047904
		public unsafe Color InstructionWarningColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionWarningColor)) = value;
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x060097AA RID: 38826 RVA: 0x00270C40 File Offset: 0x0026EE40
		// (set) Token: 0x060097AB RID: 38827 RVA: 0x0004971F File Offset: 0x0004791F
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x060097AC RID: 38828 RVA: 0x00270C70 File Offset: 0x0026EE70
		// (set) Token: 0x060097AD RID: 38829 RVA: 0x0004973E File Offset: 0x0004793E
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x060097AE RID: 38830 RVA: 0x00270CA0 File Offset: 0x0026EEA0
		// (set) Token: 0x060097AF RID: 38831 RVA: 0x0004975D File Offset: 0x0004795D
		public unsafe ItemSlotUI PackagingSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_PackagingSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x060097B0 RID: 38832 RVA: 0x00270CD0 File Offset: 0x0026EED0
		// (set) Token: 0x060097B1 RID: 38833 RVA: 0x0004977C File Offset: 0x0004797C
		public unsafe ItemSlotUI ProductSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ProductSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x060097B2 RID: 38834 RVA: 0x00270D00 File Offset: 0x0026EF00
		// (set) Token: 0x060097B3 RID: 38835 RVA: 0x0004979B File Offset: 0x0004799B
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x060097B4 RID: 38836 RVA: 0x00270D30 File Offset: 0x0026EF30
		// (set) Token: 0x060097B5 RID: 38837 RVA: 0x000497BA File Offset: 0x000479BA
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x060097B6 RID: 38838 RVA: 0x00270D60 File Offset: 0x0026EF60
		// (set) Token: 0x060097B7 RID: 38839 RVA: 0x000497D9 File Offset: 0x000479D9
		public unsafe Image InstructionShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_InstructionShadow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x060097B8 RID: 38840 RVA: 0x00270D90 File Offset: 0x0026EF90
		// (set) Token: 0x060097B9 RID: 38841 RVA: 0x000497F8 File Offset: 0x000479F8
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x060097BA RID: 38842 RVA: 0x00270DC0 File Offset: 0x0026EFC0
		// (set) Token: 0x060097BB RID: 38843 RVA: 0x00049817 File Offset: 0x00047A17
		public unsafe Animation ModeAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ModeAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x060097BC RID: 38844 RVA: 0x00270DF0 File Offset: 0x0026EFF0
		// (set) Token: 0x060097BD RID: 38845 RVA: 0x00049836 File Offset: 0x00047A36
		public unsafe TextMeshProUGUI ButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationCanvas.NativeFieldInfoPtr_ButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006640 RID: 26176
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006641 RID: 26177
		private static readonly IntPtr NativeFieldInfoPtr__PackagingStation_k__BackingField;

		// Token: 0x04006642 RID: 26178
		private static readonly IntPtr NativeFieldInfoPtr_ShowHintOnOpen;

		// Token: 0x04006643 RID: 26179
		private static readonly IntPtr NativeFieldInfoPtr_ShowShiftClickHint;

		// Token: 0x04006644 RID: 26180
		private static readonly IntPtr NativeFieldInfoPtr_CurrentMode;

		// Token: 0x04006645 RID: 26181
		private static readonly IntPtr NativeFieldInfoPtr_InstructionWarningColor;

		// Token: 0x04006646 RID: 26182
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006647 RID: 26183
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006648 RID: 26184
		private static readonly IntPtr NativeFieldInfoPtr_PackagingSlotUI;

		// Token: 0x04006649 RID: 26185
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUI;

		// Token: 0x0400664A RID: 26186
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x0400664B RID: 26187
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x0400664C RID: 26188
		private static readonly IntPtr NativeFieldInfoPtr_InstructionShadow;

		// Token: 0x0400664D RID: 26189
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x0400664E RID: 26190
		private static readonly IntPtr NativeFieldInfoPtr_ModeAnimation;

		// Token: 0x0400664F RID: 26191
		private static readonly IntPtr NativeFieldInfoPtr_ButtonLabel;

		// Token: 0x04006650 RID: 26192
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006651 RID: 26193
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006652 RID: 26194
		private static readonly IntPtr NativeMethodInfoPtr_get_PackagingStation_Public_get_PackagingStation_0;

		// Token: 0x04006653 RID: 26195
		private static readonly IntPtr NativeMethodInfoPtr_set_PackagingStation_Protected_set_Void_PackagingStation_0;

		// Token: 0x04006654 RID: 26196
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006655 RID: 26197
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006656 RID: 26198
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006657 RID: 26199
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_PackagingStation_Boolean_Boolean_0;

		// Token: 0x04006658 RID: 26200
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x04006659 RID: 26201
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSlotPositions_Private_Void_0;

		// Token: 0x0400665A RID: 26202
		private static readonly IntPtr NativeMethodInfoPtr_ToggleMode_Public_Void_0;

		// Token: 0x0400665B RID: 26203
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x0400665C RID: 26204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
