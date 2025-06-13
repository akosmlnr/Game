using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200075C RID: 1884
	public class Bed : NetworkBehaviour
	{
		// Token: 0x0600AADF RID: 43743 RVA: 0x002ACCC0 File Offset: 0x002AAEC0
		// Note: this type is marked as 'beforefieldinit'.
		static Bed()
		{
			Il2CppClassPointerStore<Bed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Bed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bed>.NativeClassPtr);
			Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "MIN_SLEEP_TIME");
			Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "SLEEP_TIME_SCALE");
			Bed.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "intObj");
			Bed.NativeFieldInfoPtr_EmployeeStationThing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "EmployeeStationThing");
			Bed.NativeFieldInfoPtr_BlanketMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "BlanketMesh");
			Bed.NativeFieldInfoPtr_DefaultBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "DefaultBlanket");
			Bed.NativeFieldInfoPtr_BotanistBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "BotanistBlanket");
			Bed.NativeFieldInfoPtr_ChemistBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "ChemistBlanket");
			Bed.NativeFieldInfoPtr_PackagerBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "PackagerBlanket");
			Bed.NativeFieldInfoPtr_CleanerBlanket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "CleanerBlanket");
			Bed.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted");
			Bed.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted");
			Bed.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684314);
			Bed.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684315);
			Bed.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684316);
			Bed.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684317);
			Bed.NativeMethodInfoPtr_CanSleep_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684318);
			Bed.NativeMethodInfoPtr_UpdateMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684319);
			Bed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684320);
			Bed.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684321);
			Bed.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684322);
			Bed.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684323);
			Bed.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed>.NativeClassPtr, 100684324);
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600AAE0 RID: 43744 RVA: 0x002ACEBC File Offset: 0x002AB0BC
		public unsafe Employee AssignedEmployee
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 297097, RefRangeEnd = 297112, XrefRangeStart = 297093, XrefRangeEnd = 297097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
			}
		}

		// Token: 0x0600AAE1 RID: 43745 RVA: 0x002ACEFC File Offset: 0x002AB0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297112, XrefRangeEnd = 297126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAE2 RID: 43746 RVA: 0x002ACF38 File Offset: 0x002AB138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297126, XrefRangeEnd = 297139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAE3 RID: 43747 RVA: 0x002ACF6C File Offset: 0x002AB16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297139, XrefRangeEnd = 297150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x002ACFA0 File Offset: 0x002AB1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297224, RefRangeEnd = 297225, XrefRangeStart = 297150, XrefRangeEnd = 297224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSleep(out string noSleepReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_CanSleep_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			noSleepReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x002ACFF8 File Offset: 0x002AB1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297225, XrefRangeEnd = 297238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_UpdateMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x002AD02C File Offset: 0x002AB22C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140622, XrefRangeStart = 140600, XrefRangeEnd = 140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bed>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAE7 RID: 43751 RVA: 0x002AD068 File Offset: 0x002AB268
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x002AD0A4 File Offset: 0x002AB2A4
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x002AD0E0 File Offset: 0x002AB2E0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Bed.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x002AD11C File Offset: 0x002AB31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AAEB RID: 43755 RVA: 0x00053F6E File Offset: 0x0005216E
		public Bed(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600AAEC RID: 43756 RVA: 0x002AD150 File Offset: 0x002AB350
		// (set) Token: 0x0600AAED RID: 43757 RVA: 0x00053F77 File Offset: 0x00052177
		public unsafe static int MIN_SLEEP_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bed.NativeFieldInfoPtr_MIN_SLEEP_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600AAEE RID: 43758 RVA: 0x002AD16C File Offset: 0x002AB36C
		// (set) Token: 0x0600AAEF RID: 43759 RVA: 0x00053F85 File Offset: 0x00052185
		public unsafe static float SLEEP_TIME_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bed.NativeFieldInfoPtr_SLEEP_TIME_SCALE, (void*)(&value));
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600AAF0 RID: 43760 RVA: 0x002AD188 File Offset: 0x002AB388
		// (set) Token: 0x0600AAF1 RID: 43761 RVA: 0x00053F93 File Offset: 0x00052193
		public unsafe InteractableObject intObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_intObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600AAF2 RID: 43762 RVA: 0x002AD1B8 File Offset: 0x002AB3B8
		// (set) Token: 0x0600AAF3 RID: 43763 RVA: 0x00053FB2 File Offset: 0x000521B2
		public unsafe EmployeeHome EmployeeStationThing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_EmployeeStationThing);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_EmployeeStationThing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600AAF4 RID: 43764 RVA: 0x002AD1E8 File Offset: 0x002AB3E8
		// (set) Token: 0x0600AAF5 RID: 43765 RVA: 0x00053FD1 File Offset: 0x000521D1
		public unsafe MeshRenderer BlanketMesh
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BlanketMesh);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BlanketMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600AAF6 RID: 43766 RVA: 0x002AD218 File Offset: 0x002AB418
		// (set) Token: 0x0600AAF7 RID: 43767 RVA: 0x00053FF0 File Offset: 0x000521F0
		public unsafe Material DefaultBlanket
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_DefaultBlanket);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_DefaultBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600AAF8 RID: 43768 RVA: 0x002AD248 File Offset: 0x002AB448
		// (set) Token: 0x0600AAF9 RID: 43769 RVA: 0x0005400F File Offset: 0x0005220F
		public unsafe Material BotanistBlanket
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BotanistBlanket);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_BotanistBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600AAFA RID: 43770 RVA: 0x002AD278 File Offset: 0x002AB478
		// (set) Token: 0x0600AAFB RID: 43771 RVA: 0x0005402E File Offset: 0x0005222E
		public unsafe Material ChemistBlanket
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_ChemistBlanket);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_ChemistBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600AAFC RID: 43772 RVA: 0x002AD2A8 File Offset: 0x002AB4A8
		// (set) Token: 0x0600AAFD RID: 43773 RVA: 0x0005404D File Offset: 0x0005224D
		public unsafe Material PackagerBlanket
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_PackagerBlanket);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_PackagerBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600AAFE RID: 43774 RVA: 0x002AD2D8 File Offset: 0x002AB4D8
		// (set) Token: 0x0600AAFF RID: 43775 RVA: 0x0005406C File Offset: 0x0005226C
		public unsafe Material CleanerBlanket
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_CleanerBlanket);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_CleanerBlanket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600AB00 RID: 43776 RVA: 0x002AD308 File Offset: 0x002AB508
		// (set) Token: 0x0600AB01 RID: 43777 RVA: 0x0005408B File Offset: 0x0005228B
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x002AD330 File Offset: 0x002AB530
		// (set) Token: 0x0600AB03 RID: 43779 RVA: 0x000540A6 File Offset: 0x000522A6
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Bed.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040072A9 RID: 29353
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_SLEEP_TIME;

		// Token: 0x040072AA RID: 29354
		private static readonly System.IntPtr NativeFieldInfoPtr_SLEEP_TIME_SCALE;

		// Token: 0x040072AB RID: 29355
		private static readonly System.IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x040072AC RID: 29356
		private static readonly System.IntPtr NativeFieldInfoPtr_EmployeeStationThing;

		// Token: 0x040072AD RID: 29357
		private static readonly System.IntPtr NativeFieldInfoPtr_BlanketMesh;

		// Token: 0x040072AE RID: 29358
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultBlanket;

		// Token: 0x040072AF RID: 29359
		private static readonly System.IntPtr NativeFieldInfoPtr_BotanistBlanket;

		// Token: 0x040072B0 RID: 29360
		private static readonly System.IntPtr NativeFieldInfoPtr_ChemistBlanket;

		// Token: 0x040072B1 RID: 29361
		private static readonly System.IntPtr NativeFieldInfoPtr_PackagerBlanket;

		// Token: 0x040072B2 RID: 29362
		private static readonly System.IntPtr NativeFieldInfoPtr_CleanerBlanket;

		// Token: 0x040072B3 RID: 29363
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040072B4 RID: 29364
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040072B5 RID: 29365
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AssignedEmployee_Public_get_Employee_0;

		// Token: 0x040072B6 RID: 29366
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040072B7 RID: 29367
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040072B8 RID: 29368
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040072B9 RID: 29369
		private static readonly System.IntPtr NativeMethodInfoPtr_CanSleep_Private_Boolean_byref_String_0;

		// Token: 0x040072BA RID: 29370
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterial_Public_Void_0;

		// Token: 0x040072BB RID: 29371
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040072BC RID: 29372
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040072BD RID: 29373
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040072BE RID: 29374
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040072BF RID: 29375
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000C2F RID: 3119
		[ObfuscatedName("ScheduleOne.ObjectScripts.Bed+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E434 RID: 58420 RVA: 0x0035F0B4 File Offset: 0x0035D2B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Bed.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Bed>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bed.__c>.NativeClassPtr);
				Bed.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed.__c>.NativeClassPtr, "<>9");
				Bed.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed.__c>.NativeClassPtr, "<>9__15_0");
				Bed.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bed.__c>.NativeClassPtr, "<>9__15_1");
				Bed.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed.__c>.NativeClassPtr, 100684326);
				Bed.__c.NativeMethodInfoPtr__CanSleep_b__15_0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed.__c>.NativeClassPtr, 100684327);
				Bed.__c.NativeMethodInfoPtr__CanSleep_b__15_1_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bed.__c>.NativeClassPtr, 100684328);
			}

			// Token: 0x0600E435 RID: 58421 RVA: 0x0035F158 File Offset: 0x0035D358
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bed.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bed.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E436 RID: 58422 RVA: 0x0035F194 File Offset: 0x0035D394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297075, XrefRangeEnd = 297084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanSleep_b__15_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Bed.__c.NativeMethodInfoPtr__CanSleep_b__15_0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E437 RID: 58423 RVA: 0x0035F1E4 File Offset: 0x0035D3E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297084, XrefRangeEnd = 297093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanSleep_b__15_1(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Bed.__c.NativeMethodInfoPtr__CanSleep_b__15_1_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E438 RID: 58424 RVA: 0x0006EF7B File Offset: 0x0006D17B
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004670 RID: 18032
			// (get) Token: 0x0600E439 RID: 58425 RVA: 0x0035F234 File Offset: 0x0035D434
			// (set) Token: 0x0600E43A RID: 58426 RVA: 0x0006EF84 File Offset: 0x0006D184
			public unsafe static Bed.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bed.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bed.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bed.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004671 RID: 18033
			// (get) Token: 0x0600E43B RID: 58427 RVA: 0x0035F25C File Offset: 0x0035D45C
			// (set) Token: 0x0600E43C RID: 58428 RVA: 0x0006EF96 File Offset: 0x0006D196
			public unsafe static Il2CppSystem.Predicate<Property> __9__15_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bed.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bed.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004672 RID: 18034
			// (get) Token: 0x0600E43D RID: 58429 RVA: 0x0035F284 File Offset: 0x0035D484
			// (set) Token: 0x0600E43E RID: 58430 RVA: 0x0006EFA8 File Offset: 0x0006D1A8
			public unsafe static Il2CppSystem.Predicate<Property> __9__15_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Bed.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Bed.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098D4 RID: 39124
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040098D5 RID: 39125
			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040098D6 RID: 39126
			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x040098D7 RID: 39127
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098D8 RID: 39128
			private static readonly System.IntPtr NativeMethodInfoPtr__CanSleep_b__15_0_Internal_Boolean_Property_0;

			// Token: 0x040098D9 RID: 39129
			private static readonly System.IntPtr NativeMethodInfoPtr__CanSleep_b__15_1_Internal_Boolean_Property_0;
		}
	}
}
