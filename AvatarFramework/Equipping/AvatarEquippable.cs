using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000622 RID: 1570
	public class AvatarEquippable : MonoBehaviour
	{
		// Token: 0x06008965 RID: 35173 RVA: 0x00246B64 File Offset: 0x00244D64
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEquippable()
		{
			Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarEquippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr);
			AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AlignmentPoint");
			AvatarEquippable.NativeFieldInfoPtr_Suspiciousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "Suspiciousness");
			AvatarEquippable.NativeFieldInfoPtr_Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "Hand");
			AvatarEquippable.NativeFieldInfoPtr_TriggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "TriggerType");
			AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AnimationTrigger");
			AvatarEquippable.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "AssetPath");
			AvatarEquippable.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, "avatar");
			AvatarEquippable.NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680545);
			AvatarEquippable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680546);
			AvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680547);
			AvatarEquippable.NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680548);
			AvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680549);
			AvatarEquippable.NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680550);
			AvatarEquippable.NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680551);
			AvatarEquippable.NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680552);
			AvatarEquippable.NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680553);
			AvatarEquippable.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680554);
			AvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr, 100680555);
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x00246CFC File Offset: 0x00244EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255241, XrefRangeEnd = 255255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateAssetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008967 RID: 35175 RVA: 0x00246D30 File Offset: 0x00244F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255255, XrefRangeEnd = 255267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x00246D6C File Offset: 0x00244F6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255291, RefRangeEnd = 255294, XrefRangeStart = 255267, XrefRangeEnd = 255291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x00246DBC File Offset: 0x00244FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255294, XrefRangeEnd = 255296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x00246DF8 File Offset: 0x00244FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255296, XrefRangeEnd = 255306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x00246E34 File Offset: 0x00245034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255320, RefRangeEnd = 255321, XrefRangeStart = 255306, XrefRangeEnd = 255320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionAnimationModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600896C RID: 35180 RVA: 0x00246E68 File Offset: 0x00245068
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 255337, RefRangeEnd = 255344, XrefRangeStart = 255321, XrefRangeEnd = 255337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600896D RID: 35181 RVA: 0x00246EAC File Offset: 0x002450AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255360, RefRangeEnd = 255363, XrefRangeStart = 255344, XrefRangeEnd = 255360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string anim, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref val;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x00246EFC File Offset: 0x002450FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 255379, RefRangeEnd = 255384, XrefRangeStart = 255363, XrefRangeEnd = 255379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(anim);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600896F RID: 35183 RVA: 0x00246F40 File Offset: 0x00245140
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveMessage(string message, Il2CppSystem.Object parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEquippable.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x00246FA0 File Offset: 0x002451A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255384, XrefRangeEnd = 255392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippable>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x000411D2 File Offset: 0x0003F3D2
		public AvatarEquippable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x06008972 RID: 35186 RVA: 0x00246FDC File Offset: 0x002451DC
		// (set) Token: 0x06008973 RID: 35187 RVA: 0x000411DB File Offset: 0x0003F3DB
		public unsafe Transform AlignmentPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x06008974 RID: 35188 RVA: 0x0024700C File Offset: 0x0024520C
		// (set) Token: 0x06008975 RID: 35189 RVA: 0x000411FA File Offset: 0x0003F3FA
		public unsafe float Suspiciousness
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Suspiciousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Suspiciousness)) = value;
			}
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x06008976 RID: 35190 RVA: 0x00247034 File Offset: 0x00245234
		// (set) Token: 0x06008977 RID: 35191 RVA: 0x00041215 File Offset: 0x0003F415
		public unsafe AvatarEquippable.EHand Hand
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Hand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_Hand)) = value;
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x06008978 RID: 35192 RVA: 0x0024705C File Offset: 0x0024525C
		// (set) Token: 0x06008979 RID: 35193 RVA: 0x00041230 File Offset: 0x0003F430
		public unsafe AvatarEquippable.ETriggerType TriggerType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_TriggerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_TriggerType)) = value;
			}
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600897A RID: 35194 RVA: 0x00247084 File Offset: 0x00245284
		// (set) Token: 0x0600897B RID: 35195 RVA: 0x0004124B File Offset: 0x0003F44B
		public unsafe string AnimationTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x0600897C RID: 35196 RVA: 0x002470AC File Offset: 0x002452AC
		// (set) Token: 0x0600897D RID: 35197 RVA: 0x0004126A File Offset: 0x0003F46A
		public unsafe string AssetPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x0600897E RID: 35198 RVA: 0x002470D4 File Offset: 0x002452D4
		// (set) Token: 0x0600897F RID: 35199 RVA: 0x00041289 File Offset: 0x0003F489
		public unsafe Avatar avatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_avatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippable.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D82 RID: 23938
		private static readonly System.IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x04005D83 RID: 23939
		private static readonly System.IntPtr NativeFieldInfoPtr_Suspiciousness;

		// Token: 0x04005D84 RID: 23940
		private static readonly System.IntPtr NativeFieldInfoPtr_Hand;

		// Token: 0x04005D85 RID: 23941
		private static readonly System.IntPtr NativeFieldInfoPtr_TriggerType;

		// Token: 0x04005D86 RID: 23942
		private static readonly System.IntPtr NativeFieldInfoPtr_AnimationTrigger;

		// Token: 0x04005D87 RID: 23943
		private static readonly System.IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005D88 RID: 23944
		private static readonly System.IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005D89 RID: 23945
		private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateAssetPath_Public_Void_0;

		// Token: 0x04005D8A RID: 23946
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005D8B RID: 23947
		private static readonly System.IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_Avatar_0;

		// Token: 0x04005D8C RID: 23948
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAnimation_Public_Virtual_New_Void_0;

		// Token: 0x04005D8D RID: 23949
		private static readonly System.IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x04005D8E RID: 23950
		private static readonly System.IntPtr NativeMethodInfoPtr_PositionAnimationModel_Private_Void_0;

		// Token: 0x04005D8F RID: 23951
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTrigger_Protected_Void_String_0;

		// Token: 0x04005D90 RID: 23952
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Protected_Void_String_Boolean_0;

		// Token: 0x04005D91 RID: 23953
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetTrigger_Protected_Void_String_0;

		// Token: 0x04005D92 RID: 23954
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04005D93 RID: 23955
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B43 RID: 2883
		[OriginalName("Assembly-CSharp.dll", "", "ETriggerType")]
		public enum ETriggerType
		{
			// Token: 0x04009359 RID: 37721
			Trigger,
			// Token: 0x0400935A RID: 37722
			Bool
		}

		// Token: 0x02000B44 RID: 2884
		[OriginalName("Assembly-CSharp.dll", "", "EHand")]
		public enum EHand
		{
			// Token: 0x0400935C RID: 37724
			Left,
			// Token: 0x0400935D RID: 37725
			Right
		}
	}
}
