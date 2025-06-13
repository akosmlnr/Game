using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001DF RID: 479
	public class BrightEyed : Property
	{
		// Token: 0x060027D9 RID: 10201 RVA: 0x000F08C0 File Offset: 0x000EEAC0
		// Note: this type is marked as 'beforefieldinit'.
		static BrightEyed()
		{
			Il2CppClassPointerStore<BrightEyed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "BrightEyed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr);
			BrightEyed.NativeFieldInfoPtr_EyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "EyeColor");
			BrightEyed.NativeFieldInfoPtr_Emission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "Emission");
			BrightEyed.NativeFieldInfoPtr_LightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "LightIntensity");
			BrightEyed.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667787);
			BrightEyed.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667788);
			BrightEyed.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667789);
			BrightEyed.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667790);
			BrightEyed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667791);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000F0990 File Offset: 0x000EEB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121143, XrefRangeEnd = 121145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000F09E0 File Offset: 0x000EEBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121145, XrefRangeEnd = 121147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000F0A30 File Offset: 0x000EEC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121147, XrefRangeEnd = 121149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000F0A80 File Offset: 0x000EEC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121149, XrefRangeEnd = 121151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000F0AD0 File Offset: 0x000EECD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121151, XrefRangeEnd = 121152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrightEyed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrightEyed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00015E09 File Offset: 0x00014009
		public BrightEyed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000F0B0C File Offset: 0x000EED0C
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x00015E12 File Offset: 0x00014012
		public unsafe Color EyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_EyeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_EyeColor)) = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x000F0B34 File Offset: 0x000EED34
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x00015E2D File Offset: 0x0001402D
		public unsafe float Emission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_Emission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_Emission)) = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x000F0B5C File Offset: 0x000EED5C
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x00015E48 File Offset: 0x00014048
		public unsafe float LightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_LightIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_LightIntensity)) = value;
			}
		}

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr_EyeColor;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeFieldInfoPtr_Emission;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeFieldInfoPtr_LightIntensity;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
