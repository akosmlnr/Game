using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000623 RID: 1571
	public class AvatarEquippableLookAt : MonoBehaviour
	{
		// Token: 0x06008980 RID: 35200 RVA: 0x00247104 File Offset: 0x00245304
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEquippableLookAt()
		{
			Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarEquippableLookAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr);
			AvatarEquippableLookAt.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, "Priority");
			AvatarEquippableLookAt.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, "avatar");
			AvatarEquippableLookAt.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680556);
			AvatarEquippableLookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680557);
			AvatarEquippableLookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680558);
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x00247198 File Offset: 0x00245398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255392, XrefRangeEnd = 255406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x002471CC File Offset: 0x002453CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255406, XrefRangeEnd = 255413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x00247200 File Offset: 0x00245400
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippableLookAt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x000412A8 File Offset: 0x0003F4A8
		public AvatarEquippableLookAt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x06008985 RID: 35205 RVA: 0x0024723C File Offset: 0x0024543C
		// (set) Token: 0x06008986 RID: 35206 RVA: 0x000412B1 File Offset: 0x0003F4B1
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x06008987 RID: 35207 RVA: 0x00247264 File Offset: 0x00245464
		// (set) Token: 0x06008988 RID: 35208 RVA: 0x000412CC File Offset: 0x0003F4CC
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D94 RID: 23956
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04005D95 RID: 23957
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005D96 RID: 23958
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005D97 RID: 23959
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005D98 RID: 23960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
