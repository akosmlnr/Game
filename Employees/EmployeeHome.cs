using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Storage;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x0200042A RID: 1066
	public class EmployeeHome : MonoBehaviour
	{
		// Token: 0x060059D4 RID: 22996 RVA: 0x001A47FC File Offset: 0x001A29FC
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeHome()
		{
			Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "EmployeeHome");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr);
			EmployeeHome.NativeFieldInfoPtr__AssignedEmployee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "<AssignedEmployee>k__BackingField");
			EmployeeHome.NativeFieldInfoPtr_HomeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "HomeType");
			EmployeeHome.NativeFieldInfoPtr_Clipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "Clipboard");
			EmployeeHome.NativeFieldInfoPtr_MugshotSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "MugshotSprite");
			EmployeeHome.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "NameLabel");
			EmployeeHome.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "Storage");
			EmployeeHome.NativeFieldInfoPtr_EmployeeSpecificMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "EmployeeSpecificMeshes");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Default");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Botanist");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Chemist");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Packager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Packager");
			EmployeeHome.NativeFieldInfoPtr_SpecificMat_Cleaner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "SpecificMat_Cleaner");
			EmployeeHome.NativeFieldInfoPtr_onAssignedEmployeeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, "onAssignedEmployeeChanged");
			EmployeeHome.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674718);
			EmployeeHome.NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674719);
			EmployeeHome.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674720);
			EmployeeHome.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674721);
			EmployeeHome.NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674722);
			EmployeeHome.NativeMethodInfoPtr_UpdateStorageText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674723);
			EmployeeHome.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674724);
			EmployeeHome.NativeMethodInfoPtr_GetCashSum_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674725);
			EmployeeHome.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674726);
			EmployeeHome.NativeMethodInfoPtr_IsBuildableEntityAValidEmployeeHome_Public_Static_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674727);
			EmployeeHome.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr, 100674728);
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x060059D5 RID: 22997 RVA: 0x001A4A0C File Offset: 0x001A2C0C
		// (set) Token: 0x060059D6 RID: 22998 RVA: 0x001A4A4C File Offset: 0x001A2C4C
		public unsafe Employee AssignedEmployee
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x001A4A90 File Offset: 0x001A2C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190101, XrefRangeEnd = 190107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x001A4AC4 File Offset: 0x001A2CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190107, XrefRangeEnd = 190108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x001A4AF8 File Offset: 0x001A2CF8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 190133, RefRangeEnd = 190141, XrefRangeStart = 190108, XrefRangeEnd = 190133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssignedEmployee(Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x001A4B3C File Offset: 0x001A2D3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190185, RefRangeEnd = 190187, XrefRangeStart = 190141, XrefRangeEnd = 190185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStorageText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_UpdateStorageText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x001A4B70 File Offset: 0x001A2D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190187, XrefRangeEnd = 190197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_UpdateMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x001A4BA4 File Offset: 0x001A2DA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190214, RefRangeEnd = 190217, XrefRangeStart = 190197, XrefRangeEnd = 190214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCashSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_GetCashSum_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x001A4BE0 File Offset: 0x001A2DE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190238, RefRangeEnd = 190240, XrefRangeStart = 190217, XrefRangeEnd = 190238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCash(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x001A4C20 File Offset: 0x001A2E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190240, XrefRangeEnd = 190256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBuildableEntityAValidEmployeeHome(BuildableItem obj, out string reason)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr_IsBuildableEntityAValidEmployeeHome_Public_Static_Boolean_BuildableItem_byref_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x001A4C7C File Offset: 0x001A2E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190256, XrefRangeEnd = 190261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeHome() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeHome>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeHome.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x0002A7D1 File Offset: 0x000289D1
		public EmployeeHome(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x060059E1 RID: 23009 RVA: 0x001A4CB8 File Offset: 0x001A2EB8
		// (set) Token: 0x060059E2 RID: 23010 RVA: 0x0002A7DA File Offset: 0x000289DA
		public unsafe Employee _AssignedEmployee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr__AssignedEmployee_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr__AssignedEmployee_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x060059E3 RID: 23011 RVA: 0x001A4CE8 File Offset: 0x001A2EE8
		// (set) Token: 0x060059E4 RID: 23012 RVA: 0x0002A7F9 File Offset: 0x000289F9
		public unsafe string HomeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_HomeType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_HomeType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x060059E5 RID: 23013 RVA: 0x001A4D10 File Offset: 0x001A2F10
		// (set) Token: 0x060059E6 RID: 23014 RVA: 0x0002A818 File Offset: 0x00028A18
		public unsafe GameObject Clipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_Clipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_Clipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x060059E7 RID: 23015 RVA: 0x001A4D40 File Offset: 0x001A2F40
		// (set) Token: 0x060059E8 RID: 23016 RVA: 0x0002A837 File Offset: 0x00028A37
		public unsafe SpriteRenderer MugshotSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_MugshotSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_MugshotSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x060059E9 RID: 23017 RVA: 0x001A4D70 File Offset: 0x001A2F70
		// (set) Token: 0x060059EA RID: 23018 RVA: 0x0002A856 File Offset: 0x00028A56
		public unsafe TextMeshPro NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x060059EB RID: 23019 RVA: 0x001A4DA0 File Offset: 0x001A2FA0
		// (set) Token: 0x060059EC RID: 23020 RVA: 0x0002A875 File Offset: 0x00028A75
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x060059ED RID: 23021 RVA: 0x001A4DD0 File Offset: 0x001A2FD0
		// (set) Token: 0x060059EE RID: 23022 RVA: 0x0002A894 File Offset: 0x00028A94
		public unsafe Il2CppReferenceArray<MeshRenderer> EmployeeSpecificMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_EmployeeSpecificMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_EmployeeSpecificMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x001A4E00 File Offset: 0x001A3000
		// (set) Token: 0x060059F0 RID: 23024 RVA: 0x0002A8B3 File Offset: 0x00028AB3
		public unsafe Material SpecificMat_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Default);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Default), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x001A4E30 File Offset: 0x001A3030
		// (set) Token: 0x060059F2 RID: 23026 RVA: 0x0002A8D2 File Offset: 0x00028AD2
		public unsafe Material SpecificMat_Botanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Botanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x001A4E60 File Offset: 0x001A3060
		// (set) Token: 0x060059F4 RID: 23028 RVA: 0x0002A8F1 File Offset: 0x00028AF1
		public unsafe Material SpecificMat_Chemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Chemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x060059F5 RID: 23029 RVA: 0x001A4E90 File Offset: 0x001A3090
		// (set) Token: 0x060059F6 RID: 23030 RVA: 0x0002A910 File Offset: 0x00028B10
		public unsafe Material SpecificMat_Packager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Packager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Packager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x060059F7 RID: 23031 RVA: 0x001A4EC0 File Offset: 0x001A30C0
		// (set) Token: 0x060059F8 RID: 23032 RVA: 0x0002A92F File Offset: 0x00028B2F
		public unsafe Material SpecificMat_Cleaner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Cleaner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_SpecificMat_Cleaner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x001A4EF0 File Offset: 0x001A30F0
		// (set) Token: 0x060059FA RID: 23034 RVA: 0x0002A94E File Offset: 0x00028B4E
		public unsafe UnityEvent onAssignedEmployeeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_onAssignedEmployeeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeHome.NativeFieldInfoPtr_onAssignedEmployeeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D25 RID: 15653
		private static readonly IntPtr NativeFieldInfoPtr__AssignedEmployee_k__BackingField;

		// Token: 0x04003D26 RID: 15654
		private static readonly IntPtr NativeFieldInfoPtr_HomeType;

		// Token: 0x04003D27 RID: 15655
		private static readonly IntPtr NativeFieldInfoPtr_Clipboard;

		// Token: 0x04003D28 RID: 15656
		private static readonly IntPtr NativeFieldInfoPtr_MugshotSprite;

		// Token: 0x04003D29 RID: 15657
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04003D2A RID: 15658
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04003D2B RID: 15659
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeSpecificMeshes;

		// Token: 0x04003D2C RID: 15660
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Default;

		// Token: 0x04003D2D RID: 15661
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Botanist;

		// Token: 0x04003D2E RID: 15662
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Chemist;

		// Token: 0x04003D2F RID: 15663
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Packager;

		// Token: 0x04003D30 RID: 15664
		private static readonly IntPtr NativeFieldInfoPtr_SpecificMat_Cleaner;

		// Token: 0x04003D31 RID: 15665
		private static readonly IntPtr NativeFieldInfoPtr_onAssignedEmployeeChanged;

		// Token: 0x04003D32 RID: 15666
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0;

		// Token: 0x04003D33 RID: 15667
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedEmployee_Protected_set_Void_Employee_0;

		// Token: 0x04003D34 RID: 15668
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003D35 RID: 15669
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003D36 RID: 15670
		private static readonly IntPtr NativeMethodInfoPtr_SetAssignedEmployee_Public_Void_Employee_0;

		// Token: 0x04003D37 RID: 15671
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStorageText_Private_Void_0;

		// Token: 0x04003D38 RID: 15672
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Private_Void_0;

		// Token: 0x04003D39 RID: 15673
		private static readonly IntPtr NativeMethodInfoPtr_GetCashSum_Public_Single_0;

		// Token: 0x04003D3A RID: 15674
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0;

		// Token: 0x04003D3B RID: 15675
		private static readonly IntPtr NativeMethodInfoPtr_IsBuildableEntityAValidEmployeeHome_Public_Static_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04003D3C RID: 15676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
