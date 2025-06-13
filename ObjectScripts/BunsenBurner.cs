using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200076B RID: 1899
	public class BunsenBurner : MonoBehaviour
	{
		// Token: 0x0600AEE9 RID: 44777 RVA: 0x002BC6DC File Offset: 0x002BA8DC
		// Note: this type is marked as 'beforefieldinit'.
		static BunsenBurner()
		{
			Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BunsenBurner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr);
			BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<Interactable>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<IsDialHeld>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<CurrentDialValue>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<CurrentHeat>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr_LockDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "LockDial");
			BunsenBurner.NativeFieldInfoPtr_FlameColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlameColor");
			BunsenBurner.NativeFieldInfoPtr_LightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "LightIntensity");
			BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "HandleRotationSpeed");
			BunsenBurner.NativeFieldInfoPtr_FlamePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlamePitch");
			BunsenBurner.NativeFieldInfoPtr_Flame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Flame");
			BunsenBurner.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Light");
			BunsenBurner.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle");
			BunsenBurner.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "HandleClickable");
			BunsenBurner.NativeFieldInfoPtr_Handle_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle_Min");
			BunsenBurner.NativeFieldInfoPtr_Handle_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle_Max");
			BunsenBurner.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Highlight");
			BunsenBurner.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Anim");
			BunsenBurner.NativeFieldInfoPtr_FlameSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlameSound");
			BunsenBurner.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684881);
			BunsenBurner.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684882);
			BunsenBurner.NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684883);
			BunsenBurner.NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684884);
			BunsenBurner.NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684885);
			BunsenBurner.NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684886);
			BunsenBurner.NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684887);
			BunsenBurner.NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684888);
			BunsenBurner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684889);
			BunsenBurner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684890);
			BunsenBurner.NativeMethodInfoPtr_UpdateEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684891);
			BunsenBurner.NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684892);
			BunsenBurner.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684893);
			BunsenBurner.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684894);
			BunsenBurner.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684895);
			BunsenBurner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684896);
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600AEEA RID: 44778 RVA: 0x002BC9B4 File Offset: 0x002BABB4
		// (set) Token: 0x0600AEEB RID: 44779 RVA: 0x002BC9F0 File Offset: 0x002BABF0
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600AEEC RID: 44780 RVA: 0x002BCA30 File Offset: 0x002BAC30
		// (set) Token: 0x0600AEED RID: 44781 RVA: 0x002BCA6C File Offset: 0x002BAC6C
		public unsafe bool IsDialHeld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600AEEE RID: 44782 RVA: 0x002BCAAC File Offset: 0x002BACAC
		// (set) Token: 0x0600AEEF RID: 44783 RVA: 0x002BCAE8 File Offset: 0x002BACE8
		public unsafe float CurrentDialValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600AEF0 RID: 44784 RVA: 0x002BCB28 File Offset: 0x002BAD28
		// (set) Token: 0x0600AEF1 RID: 44785 RVA: 0x002BCB64 File Offset: 0x002BAD64
		public unsafe float CurrentHeat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x002BCBA4 File Offset: 0x002BADA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302903, XrefRangeEnd = 302923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x002BCBD8 File Offset: 0x002BADD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302923, XrefRangeEnd = 302941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x002BCC0C File Offset: 0x002BAE0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302956, RefRangeEnd = 302957, XrefRangeStart = 302941, XrefRangeEnd = 302956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_UpdateEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x002BCC40 File Offset: 0x002BAE40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 302962, RefRangeEnd = 302966, XrefRangeStart = 302957, XrefRangeEnd = 302962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDialPosition(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x002BCC80 File Offset: 0x002BAE80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302969, RefRangeEnd = 302972, XrefRangeStart = 302966, XrefRangeEnd = 302969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEF7 RID: 44791 RVA: 0x002BCCC0 File Offset: 0x002BAEC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 221206, RefRangeEnd = 221210, XrefRangeStart = 221206, XrefRangeEnd = 221210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEF8 RID: 44792 RVA: 0x002BCD00 File Offset: 0x002BAF00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221210, RefRangeEnd = 221212, XrefRangeStart = 221210, XrefRangeEnd = 221212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEF9 RID: 44793 RVA: 0x002BCD34 File Offset: 0x002BAF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302972, XrefRangeEnd = 302973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunsenBurner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEFA RID: 44794 RVA: 0x00055CEC File Offset: 0x00053EEC
		public BunsenBurner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600AEFB RID: 44795 RVA: 0x002BCD70 File Offset: 0x002BAF70
		// (set) Token: 0x0600AEFC RID: 44796 RVA: 0x00055CF5 File Offset: 0x00053EF5
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600AEFD RID: 44797 RVA: 0x002BCD98 File Offset: 0x002BAF98
		// (set) Token: 0x0600AEFE RID: 44798 RVA: 0x00055D10 File Offset: 0x00053F10
		public unsafe bool _IsDialHeld_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField)) = value;
			}
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600AEFF RID: 44799 RVA: 0x002BCDC0 File Offset: 0x002BAFC0
		// (set) Token: 0x0600AF00 RID: 44800 RVA: 0x00055D2B File Offset: 0x00053F2B
		public unsafe float _CurrentDialValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600AF01 RID: 44801 RVA: 0x002BCDE8 File Offset: 0x002BAFE8
		// (set) Token: 0x0600AF02 RID: 44802 RVA: 0x00055D46 File Offset: 0x00053F46
		public unsafe float _CurrentHeat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField)) = value;
			}
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600AF03 RID: 44803 RVA: 0x002BCE10 File Offset: 0x002BB010
		// (set) Token: 0x0600AF04 RID: 44804 RVA: 0x00055D61 File Offset: 0x00053F61
		public unsafe bool LockDial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LockDial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LockDial)) = value;
			}
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600AF05 RID: 44805 RVA: 0x002BCE38 File Offset: 0x002BB038
		// (set) Token: 0x0600AF06 RID: 44806 RVA: 0x00055D7C File Offset: 0x00053F7C
		public unsafe Gradient FlameColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600AF07 RID: 44807 RVA: 0x002BCE68 File Offset: 0x002BB068
		// (set) Token: 0x0600AF08 RID: 44808 RVA: 0x00055D9B File Offset: 0x00053F9B
		public unsafe AnimationCurve LightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LightIntensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LightIntensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600AF09 RID: 44809 RVA: 0x002BCE98 File Offset: 0x002BB098
		// (set) Token: 0x0600AF0A RID: 44810 RVA: 0x00055DBA File Offset: 0x00053FBA
		public unsafe float HandleRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed)) = value;
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600AF0B RID: 44811 RVA: 0x002BCEC0 File Offset: 0x002BB0C0
		// (set) Token: 0x0600AF0C RID: 44812 RVA: 0x00055DD5 File Offset: 0x00053FD5
		public unsafe AnimationCurve FlamePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlamePitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlamePitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600AF0D RID: 44813 RVA: 0x002BCEF0 File Offset: 0x002BB0F0
		// (set) Token: 0x0600AF0E RID: 44814 RVA: 0x00055DF4 File Offset: 0x00053FF4
		public unsafe ParticleSystem Flame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Flame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Flame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600AF0F RID: 44815 RVA: 0x002BCF20 File Offset: 0x002BB120
		// (set) Token: 0x0600AF10 RID: 44816 RVA: 0x00055E13 File Offset: 0x00054013
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600AF11 RID: 44817 RVA: 0x002BCF50 File Offset: 0x002BB150
		// (set) Token: 0x0600AF12 RID: 44818 RVA: 0x00055E32 File Offset: 0x00054032
		public unsafe Transform Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600AF13 RID: 44819 RVA: 0x002BCF80 File Offset: 0x002BB180
		// (set) Token: 0x0600AF14 RID: 44820 RVA: 0x00055E51 File Offset: 0x00054051
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600AF15 RID: 44821 RVA: 0x002BCFB0 File Offset: 0x002BB1B0
		// (set) Token: 0x0600AF16 RID: 44822 RVA: 0x00055E70 File Offset: 0x00054070
		public unsafe Transform Handle_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600AF17 RID: 44823 RVA: 0x002BCFE0 File Offset: 0x002BB1E0
		// (set) Token: 0x0600AF18 RID: 44824 RVA: 0x00055E8F File Offset: 0x0005408F
		public unsafe Transform Handle_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600AF19 RID: 44825 RVA: 0x002BD010 File Offset: 0x002BB210
		// (set) Token: 0x0600AF1A RID: 44826 RVA: 0x00055EAE File Offset: 0x000540AE
		public unsafe Transform Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600AF1B RID: 44827 RVA: 0x002BD040 File Offset: 0x002BB240
		// (set) Token: 0x0600AF1C RID: 44828 RVA: 0x00055ECD File Offset: 0x000540CD
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600AF1D RID: 44829 RVA: 0x002BD070 File Offset: 0x002BB270
		// (set) Token: 0x0600AF1E RID: 44830 RVA: 0x00055EEC File Offset: 0x000540EC
		public unsafe AudioSourceController FlameSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007595 RID: 30101
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04007596 RID: 30102
		private static readonly IntPtr NativeFieldInfoPtr__IsDialHeld_k__BackingField;

		// Token: 0x04007597 RID: 30103
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDialValue_k__BackingField;

		// Token: 0x04007598 RID: 30104
		private static readonly IntPtr NativeFieldInfoPtr__CurrentHeat_k__BackingField;

		// Token: 0x04007599 RID: 30105
		private static readonly IntPtr NativeFieldInfoPtr_LockDial;

		// Token: 0x0400759A RID: 30106
		private static readonly IntPtr NativeFieldInfoPtr_FlameColor;

		// Token: 0x0400759B RID: 30107
		private static readonly IntPtr NativeFieldInfoPtr_LightIntensity;

		// Token: 0x0400759C RID: 30108
		private static readonly IntPtr NativeFieldInfoPtr_HandleRotationSpeed;

		// Token: 0x0400759D RID: 30109
		private static readonly IntPtr NativeFieldInfoPtr_FlamePitch;

		// Token: 0x0400759E RID: 30110
		private static readonly IntPtr NativeFieldInfoPtr_Flame;

		// Token: 0x0400759F RID: 30111
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x040075A0 RID: 30112
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x040075A1 RID: 30113
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x040075A2 RID: 30114
		private static readonly IntPtr NativeFieldInfoPtr_Handle_Min;

		// Token: 0x040075A3 RID: 30115
		private static readonly IntPtr NativeFieldInfoPtr_Handle_Max;

		// Token: 0x040075A4 RID: 30116
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x040075A5 RID: 30117
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040075A6 RID: 30118
		private static readonly IntPtr NativeFieldInfoPtr_FlameSound;

		// Token: 0x040075A7 RID: 30119
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040075A8 RID: 30120
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040075A9 RID: 30121
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0;

		// Token: 0x040075AA RID: 30122
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0;

		// Token: 0x040075AB RID: 30123
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0;

		// Token: 0x040075AC RID: 30124
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0;

		// Token: 0x040075AD RID: 30125
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0;

		// Token: 0x040075AE RID: 30126
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0;

		// Token: 0x040075AF RID: 30127
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075B0 RID: 30128
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040075B1 RID: 30129
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_0;

		// Token: 0x040075B2 RID: 30130
		private static readonly IntPtr NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0;

		// Token: 0x040075B3 RID: 30131
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040075B4 RID: 30132
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040075B5 RID: 30133
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040075B6 RID: 30134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
