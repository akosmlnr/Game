using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002C4 RID: 708
	[Serializable]
	public class PlayerData : SaveData
	{
		// Token: 0x06003275 RID: 12917 RVA: 0x001144FC File Offset: 0x001126FC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerData()
		{
			Il2CppClassPointerStore<PlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerData>.NativeClassPtr);
			PlayerData.NativeFieldInfoPtr_PlayerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "PlayerCode");
			PlayerData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "Position");
			PlayerData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "Rotation");
			PlayerData.NativeFieldInfoPtr_IntroCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "IntroCompleted");
			PlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100669074);
			PlayerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100669075);
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x001145A4 File Offset: 0x001127A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137022, RefRangeEnd = 137025, XrefRangeStart = 137018, XrefRangeEnd = 137022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData(string playerCode, Vector3 playerPos, float playerRot, bool introCompleted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerRot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref introCompleted;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x0011461C File Offset: 0x0011281C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137028, RefRangeEnd = 137029, XrefRangeStart = 137025, XrefRangeEnd = 137028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x0001AABF File Offset: 0x00018CBF
		public PlayerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x00114658 File Offset: 0x00112858
		// (set) Token: 0x0600327A RID: 12922 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		public unsafe string PlayerCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_PlayerCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_PlayerCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x00114680 File Offset: 0x00112880
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x0001AAE7 File Offset: 0x00018CE7
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x001146A8 File Offset: 0x001128A8
		// (set) Token: 0x0600327E RID: 12926 RVA: 0x0001AB02 File Offset: 0x00018D02
		public unsafe float Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x0600327F RID: 12927 RVA: 0x001146D0 File Offset: 0x001128D0
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x0001AB1D File Offset: 0x00018D1D
		public unsafe bool IntroCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_IntroCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_IntroCompleted)) = value;
			}
		}

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeFieldInfoPtr_PlayerCode;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeFieldInfoPtr_IntroCompleted;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
