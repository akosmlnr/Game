using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001F2 RID: 498
	public class Shrinking : Property
	{
		// Token: 0x06002876 RID: 10358 RVA: 0x000F326C File Offset: 0x000F146C
		// Note: this type is marked as 'beforefieldinit'.
		static Shrinking()
		{
			Il2CppClassPointerStore<Shrinking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Shrinking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shrinking>.NativeClassPtr);
			Shrinking.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, "Scale");
			Shrinking.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, "LerpTime");
			Shrinking.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667899);
			Shrinking.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667900);
			Shrinking.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667901);
			Shrinking.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667902);
			Shrinking.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667903);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000F3328 File Offset: 0x000F1528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121627, XrefRangeEnd = 121628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000F3378 File Offset: 0x000F1578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121628, XrefRangeEnd = 121630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000F33C8 File Offset: 0x000F15C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121630, XrefRangeEnd = 121631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000F3418 File Offset: 0x000F1618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121631, XrefRangeEnd = 121633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000F3468 File Offset: 0x000F1668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shrinking() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shrinking>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shrinking.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00015F9D File Offset: 0x0001419D
		public Shrinking(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x000F34A4 File Offset: 0x000F16A4
		// (set) Token: 0x0600287E RID: 10366 RVA: 0x00015FA6 File Offset: 0x000141A6
		public unsafe static float Scale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Shrinking.NativeFieldInfoPtr_Scale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shrinking.NativeFieldInfoPtr_Scale, (void*)(&value));
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x000F34C0 File Offset: 0x000F16C0
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x00015FB4 File Offset: 0x000141B4
		public unsafe static float LerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Shrinking.NativeFieldInfoPtr_LerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shrinking.NativeFieldInfoPtr_LerpTime, (void*)(&value));
			}
		}

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
