using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001EC RID: 492
	public class Lethal : Property
	{
		// Token: 0x06002842 RID: 10306 RVA: 0x000F251C File Offset: 0x000F071C
		// Note: this type is marked as 'beforefieldinit'.
		static Lethal()
		{
			Il2CppClassPointerStore<Lethal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Lethal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lethal>.NativeClassPtr);
			Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lethal>.NativeClassPtr, "HEALTH_DRAIN_PLAYER");
			Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lethal>.NativeClassPtr, "HEALTH_DRAIN_NPC");
			Lethal.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667853);
			Lethal.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667854);
			Lethal.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667855);
			Lethal.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667856);
			Lethal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667857);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000F25D8 File Offset: 0x000F07D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121374, XrefRangeEnd = 121380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x000F2628 File Offset: 0x000F0828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121380, XrefRangeEnd = 121399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000F2678 File Offset: 0x000F0878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121399, XrefRangeEnd = 121404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000F26C8 File Offset: 0x000F08C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121404, XrefRangeEnd = 121422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x000F2718 File Offset: 0x000F0918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lethal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lethal>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lethal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00015F21 File Offset: 0x00014121
		public Lethal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x000F2754 File Offset: 0x000F0954
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x00015F2A File Offset: 0x0001412A
		public unsafe static float HEALTH_DRAIN_PLAYER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER, (void*)(&value));
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x000F2770 File Offset: 0x000F0970
		// (set) Token: 0x0600284C RID: 10316 RVA: 0x00015F38 File Offset: 0x00014138
		public unsafe static float HEALTH_DRAIN_NPC
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC, (void*)(&value));
			}
		}

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_DRAIN_NPC;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
