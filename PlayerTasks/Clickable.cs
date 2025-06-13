using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020B RID: 523
	public class Clickable : MonoBehaviour
	{
		// Token: 0x06002A94 RID: 10900 RVA: 0x000FA730 File Offset: 0x000F8930
		// Note: this type is marked as 'beforefieldinit'.
		static Clickable()
		{
			Il2CppClassPointerStore<Clickable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Clickable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clickable>.NativeClassPtr);
			Clickable.NativeFieldInfoPtr_ClickableEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "ClickableEnabled");
			Clickable.NativeFieldInfoPtr_AutoCalculateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "AutoCalculateOffset");
			Clickable.NativeFieldInfoPtr_FlattenZOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "FlattenZOffset");
			Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<originalHitPoint>k__BackingField");
			Clickable.NativeFieldInfoPtr_onClickStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "onClickStart");
			Clickable.NativeFieldInfoPtr_onClickEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "onClickEnd");
			Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<IsHeld>k__BackingField");
			Clickable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668147);
			Clickable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668148);
			Clickable.NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668149);
			Clickable.NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668150);
			Clickable.NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668151);
			Clickable.NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668152);
			Clickable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668153);
			Clickable.NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668154);
			Clickable.NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668155);
			Clickable.NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668156);
			Clickable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100668157);
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000FA8DC File Offset: 0x000F8ADC
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x000FA924 File Offset: 0x000F8B24
		public unsafe virtual CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31397, RefRangeEnd = 31398, XrefRangeStart = 31397, XrefRangeEnd = 31398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000FA970 File Offset: 0x000F8B70
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x000FA9AC File Offset: 0x000F8BAC
		public unsafe Vector3 originalHitPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 123854, RefRangeEnd = 123856, XrefRangeStart = 123854, XrefRangeEnd = 123854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x000FA9EC File Offset: 0x000F8BEC
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x000FAA28 File Offset: 0x000F8C28
		public unsafe bool IsHeld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 53388, RefRangeEnd = 53391, XrefRangeStart = 53388, XrefRangeEnd = 53391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x000FAA68 File Offset: 0x000F8C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123856, XrefRangeEnd = 123861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000FAA9C File Offset: 0x000F8C9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123864, RefRangeEnd = 123866, XrefRangeStart = 123861, XrefRangeEnd = 123864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000FAAE8 File Offset: 0x000F8CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123866, XrefRangeEnd = 123867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000FAB24 File Offset: 0x000F8D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123854, RefRangeEnd = 123856, XrefRangeStart = 123854, XrefRangeEnd = 123856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOriginalHitPoint(Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hitPoint;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000FAB64 File Offset: 0x000F8D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123870, RefRangeEnd = 123872, XrefRangeStart = 123867, XrefRangeEnd = 123870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Clickable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clickable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x00016EE1 File Offset: 0x000150E1
		public Clickable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x000FABA0 File Offset: 0x000F8DA0
		// (set) Token: 0x06002AA2 RID: 10914 RVA: 0x00016EEA File Offset: 0x000150EA
		public unsafe bool ClickableEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_ClickableEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_ClickableEnabled)) = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000FABC8 File Offset: 0x000F8DC8
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x00016F05 File Offset: 0x00015105
		public unsafe bool AutoCalculateOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_AutoCalculateOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_AutoCalculateOffset)) = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000FABF0 File Offset: 0x000F8DF0
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x00016F20 File Offset: 0x00015120
		public unsafe bool FlattenZOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_FlattenZOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_FlattenZOffset)) = value;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x000FAC18 File Offset: 0x000F8E18
		// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x00016F3B File Offset: 0x0001513B
		public unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x000FAC40 File Offset: 0x000F8E40
		// (set) Token: 0x06002AAA RID: 10922 RVA: 0x00016F56 File Offset: 0x00015156
		public unsafe Vector3 _originalHitPoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__originalHitPoint_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000FAC68 File Offset: 0x000F8E68
		// (set) Token: 0x06002AAC RID: 10924 RVA: 0x00016F71 File Offset: 0x00015171
		public unsafe UnityEvent<RaycastHit> onClickStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000FAC98 File Offset: 0x000F8E98
		// (set) Token: 0x06002AAE RID: 10926 RVA: 0x00016F90 File Offset: 0x00015190
		public unsafe UnityEvent onClickEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_onClickEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x000FACC8 File Offset: 0x000F8EC8
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x00016FAF File Offset: 0x000151AF
		public unsafe bool _IsHeld_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__IsHeld_k__BackingField)) = value;
			}
		}

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeFieldInfoPtr_ClickableEnabled;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeFieldInfoPtr_AutoCalculateOffset;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeFieldInfoPtr_FlattenZOffset;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeFieldInfoPtr__originalHitPoint_k__BackingField;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeFieldInfoPtr_onClickStart;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeFieldInfoPtr_onClickEnd;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr__IsHeld_k__BackingField;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_New_get_ECursorType_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_New_set_Void_ECursorType_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_get_originalHitPoint_Public_get_Vector3_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_set_originalHitPoint_Protected_set_Void_Vector3_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeld_Public_get_Boolean_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHeld_Protected_set_Void_Boolean_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_New_Void_RaycastHit_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_EndClick_Public_Virtual_New_Void_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_SetOriginalHitPoint_Public_Void_Vector3_0;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
